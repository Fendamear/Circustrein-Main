using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Train
    {
        private readonly List<Wagon> Wagons = new List<Wagon>();

        public List<Wagon> CalcTrain(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                if (!AddAnimalToWagon(animal))
                {
                    AddWagon(animal);
                }
            }
            return Wagons;
        }

        private bool AddAnimalToWagon(Animal animal)
        {
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.IsThereRoomInWagon((int)animal.Size) && !wagon.CheckAnimals(animal))
                {
                    wagon.AddAnimal(animal);
                    return true;
                }
            }
            return false;
        }

        private void AddWagon(Animal animal)
        {
            Wagons.Add(new Wagon(animal));
        }
    }
}
