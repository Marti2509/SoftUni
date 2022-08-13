using NUnit.Framework;
using System;

namespace Database.Tests
{
    public class Tests
    {
        [TestCase(new int[0])]
        [TestCase(new[] { 1 })]
        [TestCase(new[] { 4, 60, 1002, 30000, 466 })]
        [TestCase(new[] { int.MinValue, int.MaxValue, 0 })]
        public void ConstructorWithValidData(int[] input)
        {
            // Arange
            Database database = new Database(input);

            // Act & Assert
            Assert.That(database.Count, Is.EqualTo(input.Length));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16})]
        public void AddOnFullArray(int[] input)
        {
            // Arange
            Database database = new Database(input);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(17), "Array's capacity must be exactly 16 integers!");
        }

        [TestCase(new int[0], new int[0], 0)]
        [TestCase(new[] { 1 }, new[] { 1 }, 0)]
        [TestCase(new[] { 4, 60, 1002, 30000, 466 }, new[] { 466, 30000, 1002 }, 2)]
        public void RemoveShouldRemoveTheLastElementFromTheArray(int[] input, int[] elementsToRemove, int expectedCount)
        {
            // Arange
            Database database = new Database(input);

            // Act
            for (int i = 0; i < elementsToRemove.Length; i++)
            {
                database.Remove();
            }

            // Assert
            Assert.That(database.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void RemoveShouldRemoveTheLastElementFromTheArrayIfThereIsAny()
        {
            // Arange
            Database database = new Database(1);

            // Act
            database.Remove();

            // Assert
            Assert.Throws<InvalidOperationException>(() => database.Remove(), "The collection is empty!");
        }

        [TestCase(new int[0])]
        [TestCase(new[] { 1 })]
        [TestCase(new[] { 4, 60, 1002, 30000, 466 })]
        [TestCase(new[] { int.MinValue, int.MaxValue, 0 })]
        public void WhenFetchItShouldReturnTheSameArray(int[] input)
        {
            // Arange
            Database database = new Database(input);
            int[] expectedOutput = input;

            // Act & Assert
            Assert.That(expectedOutput, Is.EqualTo(database.Fetch()));
        }
    }
}
