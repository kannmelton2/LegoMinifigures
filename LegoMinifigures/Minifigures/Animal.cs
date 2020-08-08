using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Minifigures
{
    class Animal
    {
        // properties
        public string Species { get; private set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public Human Companion { get; set; }

        // fields

        // constructor
        public Animal(string name)
        {
            Name = name;
        }

        // methods
        public string WhatSpecies()
        {
            Console.WriteLine($"What Species is {Name}?");
            Species = Console.ReadLine();
            Console.WriteLine($"Hello {Name}, the {Species}!");
            return Species;
        }

        public void PlayTime()
        {
            if (Companion.ReadyToPlay)
            {
                Console.WriteLine($"{Companion.Name} says 'Let's Play Hide & Seek!'");
                Console.WriteLine("Enter yes or no");
                string response = Console.ReadLine();
                if (response == "yes")
                {
                    HideAndSeek();
                }
                Companion.ReadyToPlay = false;
            }
            else
            {
                Console.WriteLine($"{Companion.Name} says 'I'm too tired for Hide & Seek right now. Let's relax awhile.");
                Console.WriteLine("Enter yes or no");
                string response = Console.ReadLine();
                if (response == "yes")
                {
                    Relax();
                }
            }
        }

        private void HideAndSeek()
        {
            Console.WriteLine($"{Name} and {Companion.Name} are playing hide and seek!");
        }

        private void Relax()
        {
            if (Companion.ReadyToPlay == false)
            {
                Console.WriteLine($"{Companion.Name} says 'This is the life, isn't it {Name}?");
                Companion.ReadyToPlay = true;
            }
            else
            {
                Console.WriteLine($"{Companion.Name} says 'I'm feeling well rested and ready to play!");
            }
        }
    }
}
