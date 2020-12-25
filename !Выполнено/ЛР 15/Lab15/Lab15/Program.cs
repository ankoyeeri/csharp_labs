using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;


namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int i = 1;
                Console.WriteLine($"{i++}) {nameof(FunctionController.Task1)}");
                Console.WriteLine($"{i++}) {nameof(FunctionController.Task2)}");
                Console.WriteLine($"{i++}) {nameof(FunctionController.Task3)}");
                Console.WriteLine($"{i++}) {nameof(FunctionController.Task4)}");
                Console.WriteLine($"{i++}) {nameof(FunctionController.Task5)}");
                Console.WriteLine("0) Exit");
                Console.Write("---> ");
                int choise = Convert.ToInt32(Console.ReadLine());

                if (choise == 0) break;

                switch (choise)
                {
                    case 1:
                        FunctionController.Task1();
                        break;
                    case 2:
                        FunctionController.Task2();
                        break;
                    case 3:
                        FunctionController.Task3();
                        break;
                    case 4:
                        FunctionController.Task4();
                        break;
                    case 5:
                        FunctionController.Task5();
                        break;
                }
            }
        }
    }
}
