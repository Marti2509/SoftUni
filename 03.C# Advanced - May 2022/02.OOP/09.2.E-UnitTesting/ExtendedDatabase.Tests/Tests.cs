using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ExtendedDatabase.Tests
{
    public class Tests
    {
        [Test]
        public void WhenAddPersonShouldReturnTheCorrectCount()
        {
            // Arange
            Database database = new Database();
            database.Add(new Person(33332117, "Misho"));
            database.Add(new Person(25992666, "Marto"));
            database.Add(new Person(55882444, "Emi"));
            database.Add(new Person(11661983, "Tate"));
            database.Add(new Person(17551983, "Mama"));

            // Act & Assert
            Assert.AreEqual(5, database.Count);
        }

        [Test]
        public void WhenAddPersonWithTheSameUsernameShouldThrowExeption()
        {
            // Arange
            Database database = new Database();
            database.Add(new Person(33332117, "Misho"));
            database.Add(new Person(25992666, "Marto"));
            database.Add(new Person(55882444, "Emi"));
            database.Add(new Person(11661983, "Tate"));
            database.Add(new Person(17551983, "Mama"));

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(25992666, "Marto")), "There is already user with this username!");
        }

        [Test]
        public void WhenAddPersonWithTheSameIDShouldThrowExeption()
        {
            // Arange
            Database database = new Database();
            database.Add(new Person(33332117, "Misho"));
            database.Add(new Person(25992666, "Marto"));
            database.Add(new Person(55882444, "Emi"));
            database.Add(new Person(11661983, "Tate"));
            database.Add(new Person(17551983, "Mama"));

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(25992666, "Marto")), "There is already user with this Id!");
        }

        [Test]
        public void WhenAddPersonToAFullDatabaseShouldThrowExeption()
        {
            // Arange
            Database database = new Database();
            database.Add(new Person(33332, "Mi")); // 1
            database.Add(new Person(333321, "Mis")); // 2
            database.Add(new Person(3333211, "Mish")); // 3
            database.Add(new Person(33332117, "Misho")); // 4
            database.Add(new Person(2599266, "Mar")); // 5
            database.Add(new Person(259926, "Mart")); // 6
            database.Add(new Person(25992666, "Marto")); // 7
            database.Add(new Person(5588244, "E")); // 8
            database.Add(new Person(558824, "Em")); // 9
            database.Add(new Person(55882444, "Emi")); // 10
            database.Add(new Person(1166198, "Ta")); // 11
            database.Add(new Person(116619, "Tat")); // 12
            database.Add(new Person(11661983, "Tate")); // 13
            database.Add(new Person(175519, "Ma")); // 14
            database.Add(new Person(1755198, "Mam")); // 15
            database.Add(new Person(17551983, "Mama")); // 16

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(3333, "M")), "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void WhenAddRangeTryToAddTooManyPeopleShouldThrowExeption()
        {
            // Arange
            Database database = new Database();

            List<Person> people = new List<Person>();
            people.Add(new Person(33332, "Mi")); // 1
            people.Add(new Person(333321, "Mis")); // 2
            people.Add(new Person(3333211, "Mish")); // 3
            people.Add(new Person(33332117, "Misho")); // 4
            people.Add(new Person(2599266, "Mar")); // 5
            people.Add(new Person(259926, "Mart")); // 6
            people.Add(new Person(25992666, "Marto")); // 7
            people.Add(new Person(5588244, "E")); // 8
            people.Add(new Person(558824, "Em")); // 9
            people.Add(new Person(55882444, "Emi")); // 10
            people.Add(new Person(1166198, "Ta")); // 11
            people.Add(new Person(116619, "Tat")); // 12
            people.Add(new Person(11661983, "Tate")); // 13
            people.Add(new Person(175519, "Ma")); // 14
            people.Add(new Person(1755198, "Mam")); // 15
            people.Add(new Person(17551983, "Mama")); // 16
            people.Add(new Person(3333, "M")); // 17

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Database(people.ToArray()), "Provided data length should be in range [0..16]!");
        }


    }
}
