using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02.Ex6
{
    class Ex6_6abc
    {
        static void FirstFunction()
        {
            checked
            {
                int maxValue = int.MaxValue;
                int x = maxValue++;
            }
        }

        static void SecondFunction()
        {
            unchecked
            {
                int maxValue = int.MaxValue;
                int x = maxValue++;
            }
        }

        public static void Start()
        {
            try
            {
                FirstFunction();
                SecondFunction();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
        }
    }
}
