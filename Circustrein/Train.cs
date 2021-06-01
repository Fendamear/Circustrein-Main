using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Train
    {
        private List<Wagon> Wagons = new List<Wagon>();

        public List<Wagon> CalculateTrain(List<Animal> animals)
        {
            List<Animal> sortedAnimals = animals.OrderBy(x => x.Size)
                .ToList();

            foreach (Animal animal in sortedAnimals)
            {
                if (!TryAddingAnimalToExistingWagon(animal))
                {
                    Wagon wagon = new Wagon();
                    wagon.AddAnimalToWagon(animal);
                    Wagons.Add(wagon);
                }
            }
            return Wagons;
        }

        private bool TryAddingAnimalToExistingWagon(Animal animal)
        {
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.IsThereRoomInWagon((int)animal.Size) && wagon.IsAnimalCompatibleInWagon(animal))
                {
                    wagon.AddAnimalToWagon(animal);
                    return true;
                }
            }
            return false;
        }
    }
}
