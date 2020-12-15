using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09
{
    class StringProc
    {
        /// <summary>
        /// Удаление конкретного символа строки
        /// </summary>
        /// <param name="str"></param>
        /// <param name="c"></param>
        public static void DeleteCurrentSymbol(string str)
        {
            Console.Write("Введите символ, который вы хотите удалить: ");
            char c = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == c)
                {
                    str = str.Remove(i, 1);
                }
            }
            Console.WriteLine($"Результат удаления: {str}");
        }

        /// <summary>
        /// Перевод выбранного символа в верхний регистр
        /// </summary>
        /// <param name="str"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static void CharToUpper(string str)
        {
            Console.Write("Введите символ, который вы перевести в верхний регистр: ");
            char c = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    str = str.Substring(0, i) + char.ToUpper(str[i]) + str.Substring(i+1);
                }
            }
            Console.WriteLine($"Результат перевода символа в верхний регистр: {str}");
        }

        /// <summary>
        /// Перевод выбранного символа в нижний регистр
        /// </summary>
        /// <param name="str"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static void CharToLower(string str)
        {
            Console.Write("Введите символ, который вы перевести в нижний регистр: ");
            char c = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    str = str.Substring(0, i) + char.ToLower(str[i]) + str.Substring(i + 1);
                }
            }
            Console.WriteLine($"Результат перевода символа в верхний регистр: {str}");
        }

        /// <summary>
        /// Все символы в верхний регистр
        /// </summary>
        /// <param name="str"></param>
        public static void AllToUpper(string str)
        {
            Console.WriteLine("Upper case: " + str.ToUpper());
        }
        public static void AllToLower(string str)
        {
            Console.WriteLine("Lower case: " + str.ToLower());
        }
    }
}
