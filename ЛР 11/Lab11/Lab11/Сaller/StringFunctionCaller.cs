using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

using System.Text;

namespace Lab11
{
    class StringFunctionCaller
    {
        /// <summary>
        /// Вывод слов соответствующей длины
        /// </summary>
        public static void StringFirstMethod(string[] months)
        {
            Console.Write("Ввод длинны искомых слов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            IEnumerable<string> result = months.Where(p => p.Length == n);

            Console.WriteLine("\nНайденные слова по длине:");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Филтрация конкретных слов из массива
        /// </summary>
        public static void StringSecondMethod(string[] months)
        {
            string[] summerWinter = { "June", "July", "August", "December", "January", "February" };

            IEnumerable<string> result = months.Where(p => summerWinter.Any(w => p.Contains(w)));


            Console.WriteLine("\nОтфильтрованный массив:");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Вывод в алфавитном порядке
        /// </summary>
        /// <param name="months"></param>
        public static void StringThirdMethod(string[] months)
        {
            IEnumerable<string> result = months.OrderBy(p => p);

            Console.WriteLine("\nВывод в алфавитном порядке:");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Фильтрация слов с буквой u и длиной не менее 4-х символов
        /// </summary>
        /// <param name="months"></param>
        public static void StringFrthMethod(string[] months)
        {
            var result = months.Where(p => p.Any(w => p.Contains('u'))).Where(p => p.Length >= 4);

            Console.WriteLine("\nВывод строки по критериям:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
