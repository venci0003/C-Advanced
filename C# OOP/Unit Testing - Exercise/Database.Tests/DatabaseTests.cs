namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private Database database;

        [SetUp]

        public void SetUp()
        {
            this.database = new Database(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 })]

        [TestCase(new int[0])]

        [TestCase(new int[] { 1, int.MaxValue })]

        public void Test_Constructor_Params(int[] parameters)
        {
            database = new Database(parameters);

            Assert.AreEqual(parameters.Length, database.Count);
        }

        [Test]
        public void Test_If_Count_Is_Valid()
        {
            database.Remove();

            Assert.AreEqual(15, database.Count);
        }

        [Test]
        public void Test_If_Add_Method_Is_Valid()
        {
            database.Remove();
            database.Add(1);

            Assert.AreEqual(16, database.Count);
        }

        [Test]
        public void Test_If_Remove_Method_Is_Validd()
        {
            database.Remove();

            Assert.AreEqual(15, database.Count);
        }

        [Test]
        public void Test_Add_Method_With_Invalid_Index()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(10);
            });
        }

        [Test]
        public void Test_Remove_Method_Should_Not_Work()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Remove();
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }
        [Test]
        public void Test_Count_With_Zero_Elements()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Remove();
            }
            Assert.AreEqual(0, database.Count);
        }
        [Test]
        public void Test_Fetch_Method_Count()
        {
            database.Remove();
            int[] copiedArray = database.Fetch();
            Assert.AreEqual(database.Count, copiedArray.Length);
        }
    }
}
