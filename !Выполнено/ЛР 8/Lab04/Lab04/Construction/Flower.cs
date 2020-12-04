using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Lab5.Construction
{
    /// <summary>
    /// Цветок
    /// </summary>
    class Flower : Plant
    {
        private double size;
        private string color;

        /// <summary>
        /// Размер цветка
        /// <para>От 0 до 20</para>
        /// </summary>
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
