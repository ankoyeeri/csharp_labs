using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab02
{
    public class Ex1_1b
    {
        public static void Start()
        {
            // Явные преобразования
            // 1
            double a = 777.9;
            int b = (int)a;
            
            Console.WriteLine($"double ({a}) to int: {b}");

            // 2
            char c = '\u007a';
            char d = Convert.ToChar(c);
            
            Console.WriteLine($"char ({c}) to string: {d}");

            // 3
            string e = "Test";
            Object obj = e;
            object f = (object)obj;

            Console.WriteLine($"string ({e}) to object: {obj}");

            // 4
            decimal g = 722.5878e10m;
            float h = (float)g;

            Console.WriteLine($"decimal ({g}) to float: {h}");

            // 5
            int i = 9999;
            sbyte j = (sbyte)i;

            Console.WriteLine($"int ({i}) to sbyte: {j}");

            Console.WriteLine();

            // Неявные преобразования
            // 1
            int k = 9999999;
            long l = k;

            Console.WriteLine($"int ({k}) to long: {l}");

            // 2
            sbyte m = 127;
            double n = m;

            Console.WriteLine($"sbyte ({m}) to double: {n}");

            // 3
            uint o = 4294967295;
            decimal p = o;
            
            Console.WriteLine($"uint ({o}) to decimal: {p}");

            // 4
            long q = 982939475893769836;
            float r = q;

            Console.WriteLine($"long ({q}) to float: {r}");

            // 5
            float s = 2.3334e-2f;

            Console.WriteLine($"float {s} to double: {Convert.ToDouble(s)}"); ;
        }
    }
}
