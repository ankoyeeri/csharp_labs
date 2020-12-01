using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Construction
{
    class Gladiolus : Plant
    {
        readonly string name = "Гладиолус";
        public string Name { 
            get
            {
                return name;
            }
        }

        public override double Size { get; set; }

        public override void Note()
        {
            Console.WriteLine("Это гладиолус.");
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Size)}={Size.ToString()}}}";
        }
    }
}
