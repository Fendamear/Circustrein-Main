using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
    {
        private readonly List<Animal> Animals = new List<Animal>();
        private readonly int capacity = 10;

        public Wagon()
        {
            
        }

        public bool IsThereRoomInWagon(int size)
        {
            //haalt hier de huidige capaciteit op van de wagon en checkt of het dier dat er aan toegevoegd gaat worden er nog in past
            return CurrentRoomInWagon() + size <= capacity;
        }

        public void AddAnimalToWagon(Animal animal)
        {
            if (IsThereRoomInWagon((int)animal.Size) && IsAnimalCompatibleInWagon(animal))
            {
                Animals.Add(animal);
            }
            else
            {
                throw new Exception("Animal Cannot Be Added");
            }           
        }

        public int CurrentRoomInWagon()
        {
            //haalt de huidige capaciteit op
            return Animals.Sum(animal => (int)animal.Size);
        }

        public bool IsAnimalCompatibleInWagon(Animal testAnimal)
        {
            foreach (Animal animal in Animals)
            {
                if (animal.IsCarnivore)
                {
                    if (CarnEatsAnimal(animal, testAnimal)) return false;
                }
                else
                {
                    if (HerbGetsEaten(animal, testAnimal)) return false;
                }
            }
            return true;
        }

        //hier wordt gecheckt of een carnivoor het dier opeet wat toegevoegd wil worden
        private bool CarnEatsAnimal(Animal animal, Animal testAnimal)
        {
            if (!testAnimal.IsCarnivore)
            {
                if (animal.Size >= testAnimal.Size)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        //hier wordt gecheckt of een herbivoor dat toegevoegd gaat worden wordt opgegeten
        private bool HerbGetsEaten(Animal animal, Animal testAnimal)
        {
            if (!testAnimal.IsCarnivore)
            {
                return false;
            }
            else
            {
                if (animal.Size <= testAnimal.Size) return true;
            }
            return false;
        }
    }
}
