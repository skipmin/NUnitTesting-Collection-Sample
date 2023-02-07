using Collections;

namespace Collection.UnitTests
{
    public class CollectionTests
    {
        [Test]
        public void Test_Collection_EmptyConstructor() 
        {
            // Arrange and Act

            var coll = new Collections<int>();

            // Assert
            Assert.AreEqual(coll.ToString(), "[]");
        }

        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
            // Arrange and Act
            var coll = new Collections<int>(6);

            // Assert
            Assert.AreEqual(coll.ToString(), "[6]");
        }

        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {
            var coll = new Collections<int>(6, 4, 12);

            Assert.AreEqual(coll.ToString(), "[6, 4, 12]");
        }

        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            var coll = new Collections<int>(6, 4, 22);

            Assert.AreEqual(coll.Count, 3, "Check for Count");
            Assert.That(coll.Capacity, Is.GreaterThanOrEqualTo(coll.Count));
        }

        [Test]
        public void Test_Collection_Add()
        {
            // Arrange
            var coll = new Collections<string>("Alex", "Borr");

            // Act
            coll.Add("Pizza");

            // Assert
            Assert.AreEqual(coll.ToString(), "[Alex, Borr, Pizza]");
        }

        [Test]
        public void Test_Collection_GetByIndex()
        {
            var coll = new Collections<int>(3, 6, 9);
            var item = coll[1];

            Assert.That(item.ToString, Is.EqualTo("6"));
        }

        [Test]
        public void Test_Collection_SetByIndex()
        {
            var coll = new Collections<int>(3, 6, 9);
            var item = coll[1];

            Assert.That(item.ToString, Is.EqualTo("6"));
        }
    }
}