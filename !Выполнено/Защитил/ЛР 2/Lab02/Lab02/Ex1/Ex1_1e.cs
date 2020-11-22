using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02.Ex1
{
    class Ex1_1e
    {
        public static void Start()
        {
            Nullable<int> intVal = null;
            Console.WriteLine(intVal.GetValueOrDefault());

            int? nullInt = null;
            int e = nullInt ?? 0;
            Console.WriteLine(e);

            int? a = null;
            int b = 5;
            Console.WriteLine(Nullable.Compare<int>(a, b));
            
        }
    }
}
