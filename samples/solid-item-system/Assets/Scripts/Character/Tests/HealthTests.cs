using NUnit.Framework;

namespace SampaioDias.SolidItemSystem.Tests
{
    public class HealthTests
    {
        private int initialValue = 100;
        private int smallDamage = 10;
        private int smallHeal = 5;
        private int massiveAmount = 99999;

        [Test]
        public void WhenInitialized_ThenValueEqualsInitialValue()
        {
            Health health = new Health(initialValue);
            Assert.AreEqual(initialValue, health.Value);
        }

        [Test]
        public void WhenTakesDamage_ThenValueDecreases()
        {
            Health health = new Health(initialValue);
            health.Damage(smallDamage);
            Assert.AreEqual(initialValue - smallDamage, health.Value);
        }

        [Test]
        public void WhenTakesInitialValueAsDamage_ThenIsEmpty()
        {
            Health health = new Health(initialValue);
            health.Damage(initialValue);
            Assert.AreEqual(true, health.IsEmpty());
        }

        [Test]
        public void WhenTakesMassiveValueAsDamage_ThenIsEmpty()
        {
            Health health = new Health(initialValue);
            health.Damage(massiveAmount);
            Assert.AreEqual(true, health.IsEmpty());
        }

        [Test]
        public void WhenIsHealed_ThenValueIncreases()
        {
            Health health = new Health(initialValue);
            health.Damage(smallDamage);
            health.Heal(smallHeal);
            Assert.AreEqual(initialValue - smallDamage + smallHeal, health.Value);
        }

        [Test]
        public void WhenIsHealedMassivelly_ThenValueIncreasesToInitialValue()
        {
            Health health = new Health(initialValue);
            health.Damage(smallDamage);
            health.Heal(massiveAmount);
            Assert.AreEqual(initialValue, health.Value);
        }
    }
}
