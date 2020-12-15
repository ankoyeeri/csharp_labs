using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09
{
    class CallFunction
    {
        public static void Menu()
        {
            Func<string, string> func = null;
            Action<string> action = null;

            string str;
            char c;
            string resultStr;
            short listPos = 1;
            bool loopFlag = true;

            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            
            Console.WriteLine("Что вы хотите сделать со строкой?");
            Console.WriteLine($"{listPos++}) Удалить конкретный символ");
            Console.WriteLine($"{listPos++}) Все выбранные символы в верхний регистр");
            Console.WriteLine($"{listPos++}) Все выбранные символы в нижний регистр");
            Console.WriteLine($"{listPos++}) Всю строку в верхний регистр");
            Console.WriteLine($"{listPos++}) Всю строку в нижний регистр");
            Console.WriteLine($"{listPos++}) Выход");

            while (loopFlag)
            {
                Console.Write("---> ");
                var choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine($"Выбрано {nameof(StringProc.DeleteCurrentSymbol)}.");
                        action += StringProc.DeleteCurrentSymbol;
                        break;
                    case 2:
                        action += StringProc.CharToUpper;
                        Console.WriteLine($"Выбрано {nameof(StringProc.CharToUpper)}");
                        break;
                    case 3:
                        action += StringProc.CharToLower;
                        Console.WriteLine($"Выбрано {nameof(StringProc.CharToLower)}");
                        break;
                    case 4:
                        action += StringProc.AllToUpper;
                        Console.WriteLine($"Выбрано {nameof(StringProc.AllToUpper)}");
                        break;
                    case 5:
                        action += StringProc.AllToLower;
                        Console.WriteLine($"Выбрано {nameof(StringProc.CharToLower)}");
                        break;
                    case 6:
                        loopFlag = false;
                        break;
                    default:
                        Console.WriteLine("Проверьте введенное значение");
                        break;
                }
            }

            action.Invoke(str);

        }
    }
}
