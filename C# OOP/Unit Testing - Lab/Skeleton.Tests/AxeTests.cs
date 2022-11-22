using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;
        private readonly int axeAttackPoints = 1;
        private readonly int axeDurability = 10;
        [SetUp]
        public void SetUp()
        {
            this.axe = new Axe(axeAttackPoints, axeDurability);
            this.dummy = new Dummy(30, 20);
        }
        [Test]
        public void Ckeck_Wheter_Constructor_Works_Correctly()
        {
            Assert.AreEqual(axeAttackPoints, axe.AttackPoints);
            Assert.AreEqual(axeDurability, axe.DurabilityPoints);
        }
        [Test]
        public void Axe_Should_Loose_Durability_After_Attack()
        {
            axe.Attack(dummy);
            Assert.AreEqual(axeDurability - 1, axe.DurabilityPoints);
        }

        [Test]
        public void Test_For_Attack_With_Invalid_Durability()
        {
            for (int i = 1; i <= 10; i++)
            {
                axe.Attack(dummy);
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
        }
    }
}