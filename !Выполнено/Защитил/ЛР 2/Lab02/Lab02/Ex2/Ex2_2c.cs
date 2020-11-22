using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02.Ex2
{
    class Ex2_2c
    {
        public static void Start()
        {
            string varString = null;
            Console.WriteLine(String.IsNullOrEmpty(varString));
            varString = "Test";
            Console.WriteLine(String.IsNullOrEmpty(varString));

            varString = null;
            string finalString = varString ?? "";
            Console.WriteLine(finalString);
        } 
    }
}
