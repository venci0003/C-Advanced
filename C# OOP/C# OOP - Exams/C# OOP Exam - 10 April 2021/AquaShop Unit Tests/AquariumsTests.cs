namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    public class AquariumsTests
    {
        private Fish fish;

        private Aquarium aquarium;

        private List<Fish> fishes;

        [SetUp]
        public void SetUp()
        {
            fish = new Fish("Bobi");

            aquarium = new Aquarium("Bobi Paradise", 10);

        }

        [Test]
        public void Test_If_Fish_Constructor_Works()
        {
            Assert.AreEqual("Bobi", fish.Name);

            Assert.IsTrue(fish.Available);
        }

        [Test]
        public void Test_If_Aquarium_Constructor_Works()
        {
            Assert.AreEqual("Bobi Paradise", aquarium.Name);

            Assert.AreEqual(10, aquarium.Capacity);

            Assert.AreEqual(0, aquarium.Count);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Test_If_Aquarium_Name_Exception_Works(string value)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                aquarium = new Aquarium(value, 5);
            });
        }

        [TestCase(-1)]
        [TestCase(-5)]
        [TestCase(int.MinValue)]
        public void Test_If_Aquarium_Capacity_Exception_Works(int value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                aquarium = new Aquarium("Joro", value);
            });
        }
        [Test]
        public void Test_If_Add_Fish_Method_Works()
        {
            for (int i = 1; i <= 10; i++)
            {
                aquarium.Add(new Fish(string.Format($"Fish{i}")));
            }

            Assert.AreEqual(10, aquarium.Count);
        }

        [Test]
        public void Test_If_Add_Method_Exception_Works()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium = new Aquarium("Fish Paradise", 1);

                aquarium.Add(fish);

                Fish secondFish = new Fish("Nasko");

                aquarium.Add(secondFish);
            });
        }

        [Test]
        public void Test_If_Remove_Method_Exception_Works()
        {
            aquarium.Add(fish = new Fish("Zoro"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.RemoveFish("Cecko");
            });
        }
        [Test]
        public void Test_Aquarium_RemoveMethod_ShouldWork()
        {
            for (int i = 1; i <= 10; i++)
            {
                aquarium.Add(new Fish(string.Format($"Fish{i}")));
            }

            for (int i = 1; i <= 4; i++)
            {
                aquarium.RemoveFish(string.Format($"Fish{i}"));
            }
            Assert.AreEqual(6, aquarium.Count);
        }

        [Test]
        public void Test_If_Sell_Method_Exception_Works()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium.SellFish("Dani Masona");
            });
        }

        [Test]
        public void Test_If_Sell_Method_Works()
        {
            aquarium.Add(fish);

            aquarium.SellFish("Bobi");

            Assert.IsFalse(fish.Available);

            Assert.AreSame(fish, aquarium.SellFish("Bobi"));
        }

        [Test]
        public void Test_Aquarium_ReportMethod()
        {
            List<string> fishNameList = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                aquarium.Add(new Fish(string.Format($"Fish{i}")));
                fishNameList.Add($"Fish{i}");
            }
            string expectedResult = string.Format($"Fish available at {aquarium.Name}: {string.Join(", ", fishNameList)}");
            Assert.AreEqual(expectedResult, aquarium.Report());
        }
    }
}
