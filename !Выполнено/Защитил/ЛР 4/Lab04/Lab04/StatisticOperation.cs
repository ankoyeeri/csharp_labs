using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Lab04
{
    public static class StatisticOperation
    {
        public static void Sum(Set<int> set)            //  Сумма
        {
            int sum = 0;
            foreach(var item in set)
            {
                sum += item;
            }
            Console.WriteLine("\nСумма целочисленных элементов множества: " + sum);
        }

        public static void Difference(Set<int> set)     //  Разность
        {
            var difference = set.Max() - set.Min();
            Console.WriteLine("Разница максимального и минимального целочисленного элемента: " + difference);
        }

        public static void Count<T>(Set<T> set)                      //  Количетсов элементов
        {
            Console.WriteLine("Количество элементов множества: " + set.Count());
        }

        public static string DotInTheEnd_ext(this string str)
        {
            return str += ".";
        }

        public static void RemoveAllNull_ext<T>(this List<T> list)
        {
            list.RemoveAll(item => item == null);
        }
    }
}
