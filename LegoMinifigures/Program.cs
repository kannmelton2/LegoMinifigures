using LegoMinifigures.Minifigures;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var eugene = new Human("Eugene", "Brown")
            {
                Hat = HatChoice.Crown
            };

            eugene.GetDressed();

            eugene.Fight();
            
        }
    }
}
