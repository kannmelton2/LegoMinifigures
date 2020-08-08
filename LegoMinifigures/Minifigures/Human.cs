using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Minifigures
{
    class Human
    {
        // properties
        public string HairColor { get; set; }
        public HatChoice Hat { get; set; }
        public string Name { get; set; }
        public string Clothing { get; set; }
        public bool ReadyToPlay { get; set; }
        

        // constructor
        public Human(string name, string hair)
        {
            HairColor = hair;
            Name = name;
        }

        // methods
        public string GetDressed()
        {
            Console.WriteLine($"What kind of clothes does {Name} want to wear?");
            Clothing = Console.ReadLine();
            Console.WriteLine($"Great! {Name} is now wearing {Clothing}.");
            return Clothing;
        }

        public void Fight()
        {
            Console.WriteLine($"Oh, no! {Name} is being attacked. Do you want to fight back?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine($"{Name} fought off the attacker, but they got away!");
                ReadyToPlay = false;
            }
            else
            {
                Console.WriteLine($"{Name} abstained from violence and the attacker was caught and brought to justice!");
            }

        }
    }

    // enums
    enum HatChoice
    {
        None,
        Crown,
        Helmet,
        Coppola,
        Fedora,
        HardHat
    }
}
