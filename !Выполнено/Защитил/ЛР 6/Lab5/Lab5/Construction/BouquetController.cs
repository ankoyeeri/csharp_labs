using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Construction
{
    /// <summary>
    /// Класс-контроллер
    /// </summary>
    class BouquetController
    {
        /// <summary>
        /// Сортировка листа объекта <see cref="Bouquet"/> по имени
        /// </summary>
        /// <param name="bouquet"></param>
        public static void SortListByParam(Bouquet bouquet)
        {
            int counter = 0;
            string paramName = null;
            bool flagLoop = true;

            while(flagLoop)
            {
                Console.WriteLine($"По какому параметру сортировать?\n1) {nameof(bouquet.Name)}" +
                $"\n2) {nameof(bouquet.Size)}\n3) {nameof(bouquet.Color)}");
                Console.Write("---> ");

                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        bouquet.Flowers.Sort((x, y) => x.Name.CompareTo(y.Name));
                        paramName = nameof(bouquet.Name);
                        break;
                    case 2:
                        bouquet.Flowers.Sort((x, y) => x.Size.CompareTo(y.Size));
                        paramName = nameof(bouquet.Size);
                        break;
                    case 3:
                        bouquet.Flowers.Sort((x, y) => x.Color.CompareTo(y.Color));
                        paramName = nameof(bouquet.Color);
                        break;
                    default:
                        Console.WriteLine("\nПроверьте вводимое число\n");
                        break;
                }

                Console.WriteLine($"\nСортировка по {paramName}");
                foreach (var flower in bouquet.Flowers)
                {
                    Console.WriteLine($"{counter}) {flower.Name}    {flower.Size}   {Convert.ToString(flower.Color)}");
                    counter++;
                }

                Console.WriteLine("\nПродолжить сортировку?\n1) Да\n2) Нет");
                Console.Write("---> ");
                choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 2)
                    flagLoop = false;
            }
        }

        /// <summary>
        /// Поиск в листе по цвету
        /// </summary>
        /// <param name="bouquet"></param>
        public static void FindByColor(Bouquet bouquet)
        {
            int counter = 0;
            Console.Write("\nВведите искомый цвет: ");
            int color = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nИскомый цвет: {(Colors)color}\n");

            foreach(var flower in bouquet.Flowers.FindAll(element => element.Color == (Colors)color))
            {
                Console.WriteLine($"{counter++}) {flower.Name}     {flower.Size}       {Convert.ToString(flower.Color)}");
            }

        }
    }
}
