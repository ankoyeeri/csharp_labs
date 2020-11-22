using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using Lab5.Construction;

namespace Lab5.Construction
{
    /// <summary>
    /// Букет.
    /// <para>Класс-контейнер</para>
    /// </summary>
    class Bouquet : Flower, IPaper  
    {
        string IPaper.Color { get; set; }

        /// <summary>
        /// Цена букета
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// Список цветов
        /// <para>List</para>
        /// </summary>
        public List<Flower> Flowers{ get; set; }

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
                   Name == bouquet.Name &&
                   Size == bouquet.Size &&
                   Color == bouquet.Color &&
                   Price == bouquet.Price &&
                   EqualityComparer<List<Flower>>.Default.Equals(Flowers, bouquet.Flowers);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Size, Color, Price, Flowers);
        }
        public override string ToString()
        {
            return $"{{{nameof(Color)}={Color}, {nameof(Price)}={Price.ToString()}, {nameof(Flowers)}={Flowers}, {nameof(Size)}={Size.ToString()}, {nameof(Color)}={Color}, {nameof(Name)}={Name}}}";
        }
    }

    static partial class ExtMethods
    {
        /// <summary>
        /// Удалить цветок
        /// </summary>
        /// <param name="flowers"></param>
        public static void DeleteFlower(this List<Flower> flowers)
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("\nХотите удалить цветы в букете?\n1)Да\n2)Нет\n---> ");
                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Delete(ref flowers);
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Проверьте введенное значение");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        /// <summary>
        /// Удаление цветка
        /// </summary>
        /// <param name="flowers"></param>
        private static void Delete(ref List<Flower> flowers)
        {
            int counter = 0;

            Console.Write("\nКакой цветок вы хотите удалить?\n---> ");
            int num = Convert.ToInt32(Console.ReadLine());
            flowers.RemoveAt(num);
            Console.WriteLine("Элемент удален");

            Console.WriteLine("\nИтоговый лист:");
            Console.WriteLine("--------------------------------------");
            foreach (var flower in flowers)
            {
                Console.WriteLine($"{counter++}) {flower.Name}      {flower.Size}       {flower.Color}");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
