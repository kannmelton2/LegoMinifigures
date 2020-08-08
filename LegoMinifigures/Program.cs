using LegoMinifigures.Minifigures;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human
            var eugene = new Human("Eugene", "Brown")
            {
                Hat = HatChoice.Crown
            };

            eugene.GetDressed();

            eugene.Fight();

            // Animal
            var pascal = new Animal("Pascal");

            pascal.WhatSpecies();

            pascal.Color = "Green";
            pascal.Companion = eugene;

            pascal.PlayTime();


        }
    }
}
