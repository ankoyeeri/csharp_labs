using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02.Ex3
{
    class Ex3_3d
    {
        public static void Start()
        {
            //  Инициаизация неявно-типизированных переменных для хранения массива и строки
            var arrayVar = new int[] { 1, 2, 3, 4, 5 };
            var strokeVar = "Test";

            Console.WriteLine("Var array");
            foreach(var a in arrayVar)
            {
                Console.Write($"{a} ");
            }

            Console.WriteLine($"\nVar stroke: {strokeVar}");
        }
    }
}
