using System;
using System.Collections.Generic;
using System.Text;

using Lab10.Construction;
using Lab10.Exceptions;

namespace Lab10.Сontrollers
{
    /// <summary>
    /// Class-controller for <see cref="Employee"/> class
    /// </summary>
    class HashtableCollectionController
    {
        /// <summary>
        /// Add element into hashtable
        /// </summary>
        /// <param name="employee"></param>
        public static void Add(Employee employee)
        {
            while (true)
            {
                Console.WriteLine("Добавить элемент в хеш-таблицу?:\n1)Да\n2)Нет");
                Console.Write("---> ");
                int choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 1)
                {
                    Console.Write("Сколько добавить элементов: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < num; i++)
                    {
                        Console.Write("Введите ключ: ");
                        string key = Console.ReadLine();

                        Console.Write("Введите должность работника: ");
                        string position = Console.ReadLine();
                        employee.Add(key, position);
                    }
                }
                else if (choise == 2)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Неверное значение");
                }
            }
        }

        /// <summary>
        /// Remove element from hashtable
        /// </summary>
        /// <param name="employee"></param>
        public static void Remove(Employee employee)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Хотите удалить элемент из таблицы?");
                Console.WriteLine("1) Да\n2) Нет");
                Console.Write("---> ");
                int choise = Convert.ToInt32(Console.ReadLine());

                employee.Show();

                switch (choise)
                {
                    case 1:
                        Console.Write("Введите полный ключ или символ, для удаления ключей: ");
                        string key = Console.ReadLine();
                        employee.Remove(key);
                        break;
                    case 2:
                        Console.Clear();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Неверное значение");
                        Console.Clear();
                        break;
                }
            }           
        }

        public static void Search(Employee employee)
        {
            while(true)
            {
                Console.WriteLine("Произвести поиск?\n1) Да\n2) Нет");
                int choise = Convert.ToInt32(Console.ReadLine());
                if(choise == 2)
                {
                    break;
                }
                else
                {
                    Console.Write("Введите искомый элемент: ");
                    string word = Console.ReadLine();
                    employee.Search(word);
                }
            }
           
        }

        public static void Show(Employee employee)
        {
            Console.WriteLine("Содержимое хеш-таблицы:");
            employee.Show();
        }
    }
}
