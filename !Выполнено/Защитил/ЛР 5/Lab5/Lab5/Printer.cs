using System;
using System.Collections.Generic;
using System.Text;

using Lab5.Construction;

namespace Lab5
{
    class Printer
    {
        public static void IAmPrinting(Plant plant)
        {
            if (plant is Flower)
            {
                Console.WriteLine(plant.ToString());
            }
            if (plant is Rose)
            {
                Console.WriteLine(plant.ToString());
            }
            if (plant is Shrub)
            {
                Console.WriteLine(plant.ToString());
            }
            if (plant is Cactus)
            {
                Console.WriteLine(plant.ToString());
            }
            if (plant is Gladiolus)
            {
                Console.WriteLine(plant.ToString());
            }
        }

    }
}
