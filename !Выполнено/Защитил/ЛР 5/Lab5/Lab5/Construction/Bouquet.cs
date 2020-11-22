using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab5.Construction
{
    class Bouquet : Plant, IPaper
    {
        public string Color { get; set; }   //  Цвет бумаги букета
        public float Price { get; set; }

        public Flower[] flowers;

        public Flower[] SeNumberOfFlowers(ref Flower[] flowers, int number)
        {
            flowers = new Flower[number];

            for (int i = 0; i < number; i++)
            {
                flowers[i] = new Flower();
                Console.Write("\nВведите название цветка: ");
                flowers[i].Name = Console.ReadLine();
                Console.Write("\nВведите Размер цветка: ");
                flowers[i].Size = Convert.ToDouble(Console.ReadLine());
            }

            return flowers;
        }

        void IPaper.Note()
        {
            Console.WriteLine("Это букет. Метод унаследован от интерфейса");
        }

        public override void Note()
        {
            Console.WriteLine("Это букет. Метод унаследован от абстрактного класса");
        }

        public override bool Equals(object obj)
        {
            return obj is Bouquet bouquet &&
                   Color == bouquet.Color &&
                   Price == bouquet.Price &&
                   EqualityComparer<Flower[]>.Default.Equals(flowers, bouquet.flowers);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Color, Price, flowers);
        }

        public override string ToString()
        {
            return $"{{{nameof(Color)}={Color}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}
