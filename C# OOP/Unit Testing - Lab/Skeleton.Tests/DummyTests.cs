using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;
        private readonly int dummyHealth = 10;
        private readonly int dummyExperience = 8;
        [SetUp]
        public void SetUp()
        {
            this.dummy = new Dummy(dummyHealth, dummyExperience);
        }
        [Test]
        public void Check_Wheter_Constructor_Works_Correctly()
        {
            Assert.AreEqual(dummyHealth, dummy.Health);
        }

        [Test]
        public void Dummy_Should_Be_Alive()
        {
            int attackPoints = 9;
            this.dummy.TakeAttack(attackPoints);
            Assert.AreEqual(dummyHealth - attackPoints, this.dummy.Health);
        }

        [Test]
        public void Dummy_Should_Be_Dead()
        {
            int attackPoints = 10;
            this.dummy.TakeAttack(attackPoints);
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.TakeAttack(attackPoints);
            });
        }

        [Test]
        public void Dummy_Should_Not_Give_Experience()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });
        }

        [Test]
        public void Dummy_Should_Give_Experience()
        {
            int attackPoints = 11;
            this.dummy.TakeAttack(attackPoints);

            int givenExperience = this.dummy.GiveExperience();
            Assert.AreEqual(dummyExperience, givenExperience);
        }
    }
}