using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Construction
{
    class Rose : Flower
    {
        public override double Size { get; set; }
        public string Color { get; set; }

        public override void Note()
        {
            Console.WriteLine("Это роза.");
        }

        public override string ToString()
        {
            return $"{{{nameof(Size)}={Size.ToString()}, {nameof(Color)}={Color}, {nameof(Name)}={Name}}}";
        }
    }
}
