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
                else
                {
                    Console.WriteLine("Недопустимое значение!");
                }
            }
        }

        /// <summary>
        /// Цвет цветка
        /// <list type="number">
        /// <item>Красный</item>
        /// <item>Оранжевый</item>
        /// <item>Желтый</item>
        /// <item>Зеленый</item>
        /// <item>Голубой</item>
        /// <item>Фиолетовый</item>
        /// </list>
        /// </summary>
        public Colors Color { get; set; }

        /// <summary>
        /// Перечисление
        /// </summary>


        //private string ColorGainer(int value)
        //{
        //    Colors colors;
        //    string color = "";

        //    colors = (Colors)value;
        //    color = Convert.ToString(colors);

        //    return color;
        //}

        public override void Note()
        {
            Console.WriteLine("Это цветок.");
        }

        public override string ToString()
        {
            return $"{{{nameof(Size)}={Size.ToString()}, {nameof(Color)}={Color}, {nameof(Name)}={Name}}}";
        }
    }
}
