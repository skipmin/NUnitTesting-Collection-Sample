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
        public void Test_Collection_AddWithGrow()
        {
            var coll = new Collections<int>();
            int oldCapacity = coll.Capacity;
            var newColl = Enumerable.Range(1000, 2000).ToArray();

            coll.AddRange(newColl);

            string expectedNums = "[" + string.Join(", ", newColl) + "]";
            Assert.That(coll.ToString(), Is.EqualTo(expectedNums));
            Assert.That(coll.Capacity, Is.GreaterThanOrEqualTo(oldCapacity));
            Assert.That(coll.Capacity, Is.GreaterThanOrEqualTo(coll.Count));
        }

        [Test]
        public void Test_Collection_AddRange()
        {
            var coll = new Collections<int>(6, 9);
            var newColl = Enumerable.Range(10, 50).ToArray();

            coll.AddRange(newColl);

            Assert.That(coll.Capacity, Is.GreaterThanOrEqualTo(coll.Count));
        }

        [Test]
        public void Test_Collection_GetByIndex()
        {
            // Dimo's get by index
            /*var coll = new Collections<int>(3, 6, 9); 
            var item = coll[1];

            Assert.That(item.ToString, Is.EqualTo("6"));*/

            // Softuni's get by index
            // Arrange
            var names = new Collections<string>("Peter", "Maria");

            // Act
            var item0 = names[0];
            var item1 = names[1];

            //Assert
            Assert.That(item0, Is.EqualTo("Peter"));
            Assert.That(item1, Is.EqualTo("Maria"));
        }

        [Test]
        public void Test_Collection_SetByIndex()
        {
            var coll = new Collections<int>(3, 666, 9);
            coll[1] = 666;

            Assert.That(coll.ToString(), Is.EqualTo("[3, 666, 9]"));
        }

        [Test]
        public void Test_Collection_SetByInvalidIndex()
        {
            var coll = new Collections<int>(17, 666, 23);
            coll[1] = 666;

            Assert.That(() => { var coll = coll[1]; },
                Throws.InstanceOf<InvalidOperationException>());
        }

        [Test]
        public void Test_Collection_GetByInvalidIndex()
        {
            // Dimo's get by invalid index
            /*var coll = new Collections<string>("Alex", "Borr");

            Assert.That(() => { var item = coll[2]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());*/

            // Softuni's get by invalid index
            var names = new Collections<string>("Bob", "Joe");
            Assert.That(() => { var name = names[-1]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var name = names[2]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var name = names[500]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(names.ToString(), Is.EqualTo("[Bob, Joe]"));
        }

        [Test]
        public void Test_Collection_ToStringNestedCollections()
        {
            var names = new Collections<string>("Teddy", "Gerry");
            var nums = new Collections<int>(10, 20);
            var dates = new Collections<DateTime>(); 

            var nested = new Collections<object>(names, nums, dates);
            string nestedToString = nested.ToString();

            Assert.That(nestedToString, Is.EqualTo("[[Teddy, Gerry], [10, 20], []]"));
        }
    }
}