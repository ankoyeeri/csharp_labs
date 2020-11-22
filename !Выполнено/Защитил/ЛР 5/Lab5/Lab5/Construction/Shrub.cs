using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab5.Construction
{
    class Shrub : Plant
    {
        private double size;
        public override double Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    this.size = value;
                }
                else
                {
                    Console.WriteLine("Указан размер растения не соотносимый с кустами");
                }
            }
        }

        public override void Note()
        {
            Console.WriteLine("Это куст.");
        }

        public override string ToString()
        {
            return $"{{{nameof(Size)}={Size.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
