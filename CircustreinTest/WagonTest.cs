using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Circustrein;

namespace CircustreinTest
{
    [TestClass]
    public class WagonTest
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

            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(animal);
            wagon.AddAnimalToWagon(animal2);

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

            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(animal);
            wagon.AddAnimalToWagon(animal2);

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
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(animal);

            //Assert
            Assert.IsFalse(wagon.CurrentRoomInWagon() == 10);

        }
        
        

        //arrange

        //act

        //assert















    }
}


