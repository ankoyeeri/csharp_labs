using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Construction
{
    static partial class ExtMethods
    {
        /// <summary>
        /// Добавить цветы
        /// </summary>
        /// <param name="flowers"></param>
        public static void AddFlower(this List<Flower> flowers)
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("\nХотите добавить цветов в букет?\n1)Да\n2)Нет\n---> ");
                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Add(ref flowers);
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
        /// Добавление цветка
        /// </summary>
        /// <param name="flowers"></param>
        private static void Add(ref List<Flower> flowers)
        {
            Console.Write("\nСколько вы хотите добавить цветов?\n---> ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string name;
                int color;
                double size;

                Console.WriteLine($"\n{i + 1} Цветок");

                Console.Write("\nНазвание цветка: ");
                name = Console.ReadLine();

                Console.Write("\nРазмер цветка (от 0 до 20): ");
                size = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nНомер цвета (от 1 до 10): ");
                color = Convert.ToInt32(Console.ReadLine());

                flowers.Add(new Flower { Name = name, Size = size, Color = (Colors)color });
            }
        }
    }
}
