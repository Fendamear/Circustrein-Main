using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Circustrein;

namespace CircustreinTest
{
    [TestClass]
    public class CircusTest
    {
        //arrange
        Animal animal = new Animal("Alex de Leeuw", true, Animal.Sizes.Big);

        [TestMethod]
        public void RoomInWagonFalse()
        {
            //arrange
            Animal animal = new Animal("Alex de Leeuw", false, Animal.Sizes.Big);
            Animal animal2 = new Animal("Skipper", false, Animal.Sizes.Big);
            Animal newAnimal = new Animal("Rico", false, Animal.Sizes.Big);

            Wagon wagon = new Wagon(animal);
            wagon.AddAnimal(animal2);

            //act
            bool result = wagon.IsThereRoomInWagon((int)newAnimal.Size);

            //assert
            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void RoomInWagonTrue()
        {
            //arrange
            Animal animal = new Animal("Alex de Leeuw", false, Animal.Sizes.Big);
            Animal animal2 = new Animal("Skipper", false, Animal.Sizes.Small);
            Animal newAnimal = new Animal("Rico", false, Animal.Sizes.Small);

            Wagon wagon = new Wagon(animal);
            wagon.AddAnimal(animal2);

            //act
            bool result = wagon.IsThereRoomInWagon((int)newAnimal.Size);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]

        public void CreateWagon()
        {
            //arrange
            Animal animal = new Animal("Alex de Leeuw", false, Animal.Sizes.Big);

            //act
            Wagon wagon = new Wagon(animal);

            //Assert
            Assert.IsFalse(wagon.CurrentRoomInWagon() == 10);

        }
        
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
            List<Wagon> result = train.CalcTrain(animals);

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
            List<Wagon> result = train.CalcTrain(animals);

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
            List<Wagon> result = train.CalcTrain(animals);

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
            List<Wagon> result = train.CalcTrain(animals);

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
            List<Wagon> result = train.CalcTrain(animals);

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
            List<Wagon> result = train.CalcTrain(animals);

            //assert
            Assert.IsTrue(result.Count == 1);
        }

        //arrange

        //act

        //assert















    }
}


