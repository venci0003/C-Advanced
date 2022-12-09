using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Gyms.Tests
{
    public class GymsTests
    {
        private Athlete athlete;

        private Gym gym;

        [SetUp]
        public void SetUp()
        {
            athlete = new Athlete("Choki");

            gym = new Gym("Choki Gym", 10);
        }

        [Test]
        public void Test_If_Athlete_Constructor_Works()
        {
            Assert.AreEqual("Choki", athlete.FullName);

            Assert.IsFalse(athlete.IsInjured);
        }

        [Test]
        public void Test_If_Gym_Constructor_Works()
        {
            Assert.AreEqual("Choki Gym", gym.Name);

            Assert.AreEqual(10, gym.Capacity);

            Assert.AreEqual(0, gym.Count);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Test_If_Name_Exception_Works(string value)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                gym = new Gym(value, 11);
            });
        }

        [TestCase(-1)]
        [TestCase(-5)]
        [TestCase(int.MinValue)]
        public void Test_If_Capacity_Exception_Works(int value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                gym = new Gym("Ceci Gym", value);
            });
        }

        [Test]
        public void Test_If_Add_Method_Works()
        {
            athlete = new Athlete("Ceci");

            gym.AddAthlete(athlete);

            Assert.AreEqual(1, gym.Count);
        }

        [Test]
        public void Test_If_Add_Exception_Works()
        {
            gym = new Gym("Gosho Gym", 1);

            athlete = new Athlete("Ceci");

            Athlete athleteSecond = new Athlete("Kosio");

            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.AddAthlete(athlete);

                gym.AddAthlete(athleteSecond);
            });
        }

        [Test]
        public void Test_If_Remove_Method_Works()
        {
            athlete = new Athlete("Ceci");

            gym.AddAthlete(athlete);

            gym.RemoveAthlete("Ceci");

            Assert.AreEqual(0, gym.Count);

        }

        [Test]
        public void Test_If_Remove_Exception_Works()
        {
            athlete = new Athlete("Ceci");

            gym.AddAthlete(athlete);

            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.RemoveAthlete("Joro");
            });
        }

        [Test]
        public void Test_If_Athlete_Method_Works()
        {
            athlete = new Athlete("Ceci");

            gym.AddAthlete(athlete);

            Athlete expectedAthlete = gym.InjureAthlete("Ceci");

            Assert.IsTrue(athlete.IsInjured);

            Assert.AreSame(expectedAthlete, athlete);
        }


        [Test]
        public void Test_If_Athlete_Exception_Works()
        {
            athlete = new Athlete("Ceci");

            gym.AddAthlete(athlete);

            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.InjureAthlete("Joro");
            });
        }

        [Test]
        public void Test_If_Report_Works()
        {
            gym = new Gym("Koceto Gym", 5);

            List<string> athletes = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                Athlete newAthlete = new Athlete(string.Format($"Athlete{i}"));

                athletes.Add(newAthlete.FullName);

                gym.AddAthlete(newAthlete);
            }

            string expectedResult = string.Format($"Active athletes at {gym.Name}: {string.Join(", ", athletes)}");

            Assert.AreEqual(expectedResult, gym.Report());
        }
    }
}
