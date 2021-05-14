using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Animal
    {
        // enum maken voor sizes
        public enum Sizes : int { Big = 5, Medium = 3, Small = 1}

        //properties
        public string Name { get;  set; }
        public bool IsCarnivore { get; set; }

        public Sizes Size { get; set; }

        //constructor
        public Animal(string AnimalName, bool isCarnivore, Sizes AnimalSize)
        {
            Name = AnimalName;
            IsCarnivore = isCarnivore;
            Size = AnimalSize;
        }

    }
}
