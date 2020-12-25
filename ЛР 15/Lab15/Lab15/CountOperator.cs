using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    public class CountOperator
    {
        public static void CountNumTo()
        {
            int i = 0;
            int n = 5;

            Console.WriteLine($"Count until {n}");

            while(i <= n)
            {
                Console.WriteLine(i++);
            }
        }
    }
}
