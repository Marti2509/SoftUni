using NUnit.Framework;
using System;

namespace Tests
{
    public class AxeTests
    {
        [Test]
        public void WeaponShouldLosesDurabilityAfterAttact()
        {
            // Arange
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(9, axe.DurabilityPoints);
        }

        [Test]
        public void AttackingWithBrokenWepon()
        {
            // Arange
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 0);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}
