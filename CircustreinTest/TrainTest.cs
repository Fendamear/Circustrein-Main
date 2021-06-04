using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Circustrein;

namespace CircustreinTest
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void CarnivoreCannotFitCarnivore()
        {
            //arrange
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("Alex de Leeuw", true, Animal.Sizes.Big));
            animals.Add(new Animal("Skipper", true, Animal.Sizes.Medium));
            animals.Add(new Animal("Rico", true, Animal.Sizes.Small));

            //act
            List<Wagon> result = train.CalculateTrain(animals);

            //assert
            Assert.IsTrue(result.Count == 3);

        }

        [TestMethod]
        public void HerbivoresCanFitTogether()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("Alex de Leeuw", false, Animal.Sizes.Big));
            animals.Add(new Animal("Skipper", false, Animal.Sizes.Medium));
            animals.Add(new Animal("Rico", false, Animal.Sizes.Small));

            //act
            List<Wagon> result = train.CalculateTrain(animals);

            //assert
            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void MediumCarnCanFitBigHerb()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("Alex de Leeuw", false, Animal.Sizes.Big));
            animals.Add(new Animal("Skipper", true, Animal.Sizes.Medium));

            //Act
            List<Wagon> result = train.CalculateTrain(animals);

            //assert
            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void BigHerbCantFitBigCarn()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("Alex de Leeuw", false, Animal.Sizes.Big));
            animals.Add(new Animal("Skipper", true, Animal.Sizes.Big));

            //Act
            List<Wagon> result = train.CalculateTrain(animals);

            //assert
            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void MediumHerbCantFitMediumCarn()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("Alex de Leeuw", true, Animal.Sizes.Medium));
            animals.Add(new Animal("Skipper", false, Animal.Sizes.Medium));

            //Act
            List<Wagon> result = train.CalculateTrain(animals);

            //assert
            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]

        public void BigHerbCanFitMediumCarn()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("Alex de Leeuw", true, Animal.Sizes.Medium));
            animals.Add(new Animal("Skipper", false, Animal.Sizes.Big));

            //Act
            List<Wagon> result = train.CalculateTrain(animals);

            //assert
            Assert.IsTrue(result.Count == 1);
        }
    }
}
