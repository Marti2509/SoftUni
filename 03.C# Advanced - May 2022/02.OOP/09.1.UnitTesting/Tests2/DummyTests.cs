using NUnit.Framework;
using System;

namespace P02.TestDummy
{
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthWhenTheyGetAttact()
        {
            // Arange
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(1, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.That(dummy.Health, Is.EqualTo(9));
        }

        [Test]
        public void DeadDummyThrowsAnExeptionWhenAttacked()
        {
            // Arange
            Dummy dummy = new Dummy(0, 10);
            Axe axe = new Axe(10, 10);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            // Arange
            Dummy dummy = new Dummy(0, 10);
            Axe axe = new Axe(10, 10);

            // Act & Assert
            Assert.That(10, Is.EqualTo(dummy.GiveExperience()));
        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            // Arange
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 10);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}
