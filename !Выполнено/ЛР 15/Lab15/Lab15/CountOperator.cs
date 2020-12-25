using System;
using System.IO;
using System.Threading;

namespace Lab15
{
    public class CountOperator
    {
        public static void CountSimpleNumTo()
        {
            int n = 15;

            using (StreamWriter sw = new StreamWriter("ThreadFuncFile.txt", false))
            {
                Console.WriteLine($"Search simple nums until {n}");
                sw.WriteLine($"Count until {n}");
                int p;
                int num;

                for (int i = 2; i <= (int)n; i++)
                {
                    p = 1;
                    num = 2;
                    while (num < i)
                    {
                        if (i % num == 0)
                        {
                            p = 0;
                            break;
                        }
                        num++;
                    }
                    if (p == 1)
                    {
                        Console.Write($"{i} ");
                        sw.Write($"{i} ");
                        Thread.Sleep(500);
                    }
                }
            }
            Console.WriteLine("\nEnd of writing.");
        }

        public static void ClockFunc(object n)
        {
            Console.Clear();
            Console.WriteLine("\t  Current time:");
            Console.WriteLine($"\tDate: {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}");
            Console.WriteLine($"\tTime: {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
        }

    }
}
