using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Lab14.Construction
{
    public class Flower : Plant
    {
        private double size;
        public override double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if(value > 0 && value <= 20)
                {
                    size = value;
                }
                else
                {
                    Console.WriteLine("Недопустимое значение!");
                }
            }
        }
        public override void Note()
        {
            Console.WriteLine("Это цветок.");
        }

        public override string ToString()
        {
            return $"{{{nameof(Size)}={Size.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
