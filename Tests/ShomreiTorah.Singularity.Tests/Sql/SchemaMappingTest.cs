using ShomreiTorah.Singularity.Sql;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using ShomreiTorah.Singularity;
using System.Xml.Linq;

namespace ShomreiTorah.Singularity.Tests.Sql {
	[TestClass]
	public class SchemaMappingTest {
		public TestContext TestContext { get; set; }

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion

		[TestMethod]
		[ExpectedException(typeof(ArgumentException), AllowDerivedTypes = false)]
		public void NoCalculatedColumnsTest() {
			var schema = new TableSchema("NoCalculatedColumnsTest");
			var cc = schema.Columns.AddCalculatedColumn<int>("Calculated", row => 4);
			var mapping = new SchemaMapping(schema);

			Assert.AreEqual(0, mapping.Columns.Count);

			mapping.Columns.AddMapping(cc);
		}

		[TestMethod]
		public void ColumnsTest() {
			var schema = new TableSchema("ColumnsTest");
			schema.Columns.AddValueColumn("Col1", typeof(int), 5);
			schema.Columns.AddValueColumn("Col2", typeof(int), 5);
			var cc = schema.Columns.AddCalculatedColumn<int>("Calculated", row => 4);
			schema.Columns.AddValueColumn("Col4", typeof(int), 5);

			var mapping = new SchemaMapping(schema);

			Assert.AreEqual(3, mapping.Columns.Count);
			Assert.IsNull(mapping.Columns[cc]);
			Assert.AreEqual(schema.Columns.Last(), mapping.Columns[2].Column);
			Assert.AreEqual(schema.Columns[1], mapping.Columns["Col2"].Column);
		}
		[TestMethod]
		public void ColumnEventsTest() {
			var schema = new TableSchema("ColumnEventsTest");
			schema.Columns.AddValueColumn("Col1", typeof(int), 5);
			schema.Columns.AddValueColumn("Col2", typeof(int), 5);
			var cc = schema.Columns.AddCalculatedColumn<int>("Calculated", row => 4);
			schema.Columns.AddValueColumn("Col4", typeof(int), 5);

			var mapping = new SchemaMapping(schema);

			var cc2 = schema.Columns.AddCalculatedColumn<long>("Other Calculated", row => row.Field<int>("Col1") * (long)row["Col2"]);
			Assert.AreEqual(3, mapping.Columns.Count);
			var lastCol = schema.Columns.AddValueColumn("Col6", typeof(int), 7);

			Assert.AreEqual(4, mapping.Columns.Count);
			Assert.AreEqual(lastCol, mapping.Columns[3].Column);

			schema.Columns.RemoveColumn(cc2);
			schema.Columns.RemoveColumn("Col2");

			Assert.AreEqual(3, mapping.Columns.Count);
			Assert.AreEqual(lastCol, mapping.Columns[2].Column);
			mapping.Columns.RemoveMapping(lastCol);
			Assert.AreEqual(2, mapping.Columns.Count);

			Assert.AreEqual(schema.Columns["Col4"], mapping.Columns[1].Column);
			Assert.AreEqual("Col4", mapping.Columns[1].SqlName);
		}

		[TestMethod]
		public void PrimaryKeyTest() {
			var schema = new TableSchema("PrimaryKeyTest");
			schema.Columns.AddValueColumn("Col1", typeof(int), 5);
			schema.PrimaryKey = schema.Columns.AddValueColumn("Col2", typeof(int), 5);
			var cc = schema.Columns.AddCalculatedColumn<int>("Calculated", row => 4);
			schema.Columns.AddValueColumn("Col4", typeof(int), 5);

			var mapping = new SchemaMapping(schema);

			Assert.AreEqual(3, mapping.Columns.Count);
			Assert.AreEqual(schema.PrimaryKey, schema.Columns[1]);
			Assert.AreEqual(mapping.PrimaryKey, mapping.Columns[1]);
			Assert.AreEqual(mapping.PrimaryKey.Column, schema.PrimaryKey);
		}

		[TestMethod]
		public void SqlNameTest() {
			var schema = new TableSchema("SqlNameTest");
			var mapping = new SchemaMapping(schema);

			Assert.AreEqual(mapping.SqlName, schema.Name);
			Assert.IsNull(mapping.SqlSchemaName);
		}

		[Description("Tests XML persistence for the simple properties of SchemaMapping")]
		[TestMethod]
		public void XmlPropertiesTest() {
			var schema = new TableSchema("XmlPropertiesTest");

			var mapping = new SchemaMapping(schema);
			var newMapping = SchemaMapping.FromXml(mapping.ToXml(), schema);

			TestMapping(mapping);

			mapping.SqlSchemaName = "ABC";
			TestMapping(mapping);

			mapping.SqlName = "DEF";
			TestMapping(mapping);
		}

		[Description("Tests XML persistence for column mappings")]
		[TestMethod]
		public void XmlColumnsTest() {
			var schema = new TableSchema("XmlColumnsTest");
			var col1 = schema.Columns.AddValueColumn("Col1", typeof(int), null);
			var col2 = schema.Columns.AddValueColumn("Col2", typeof(int), null);
			var col3 = schema.Columns.AddValueColumn("Col3", typeof(int), null);

			var mapping = new SchemaMapping(schema);

			TestMapping(mapping);

			mapping.Columns.RemoveMapping(col2);
			TestMapping(mapping);

			mapping.Columns[col3].SqlName = "Sql3";
			TestMapping(mapping);

			mapping.Columns.AddMapping(col2, "SSSSSSS");
			TestMapping(mapping);
		}

		static void TestMapping(SchemaMapping mapping) {
			AssertMappingsEqual(mapping, SchemaMapping.FromXml(mapping.ToXml(), mapping.Schema));
		}
		static void AssertMappingsEqual(SchemaMapping expected, SchemaMapping actual) {
			Assert.AreEqual(expected.Schema, actual.Schema);
			Assert.AreEqual(expected.SqlName, actual.SqlName);
			Assert.AreEqual(expected.SqlSchemaName, actual.SqlSchemaName);

			Assert.AreEqual(expected.Columns.Count, actual.Columns.Count);

			for (int i = 0; i < expected.Columns.Count; i++) {
				ColumnMapping e = expected.Columns[i], a = actual.Columns[i];
				Assert.AreEqual(e.Column, a.Column);
				Assert.AreEqual(e.SqlName, a.SqlName);
			}

			Assert.AreEqual(expected.ToXml().ToString(), actual.ToXml().ToString());
		}
	}
}
