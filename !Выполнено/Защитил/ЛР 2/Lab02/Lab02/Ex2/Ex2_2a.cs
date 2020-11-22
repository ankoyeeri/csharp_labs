using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02.Ex2
{
    class Ex2_2a
    {
        public static void Start()
        {
            string firstStroke = "12345";
            string secondStroke = "123";

            if(firstStroke.CompareTo(secondStroke) > 0)
            {
                Console.WriteLine("fristStroke > secondStroke");
            }
            else
            {
                Console.WriteLine("fristStroke < secondStroke");
            }
        }
    }
}
