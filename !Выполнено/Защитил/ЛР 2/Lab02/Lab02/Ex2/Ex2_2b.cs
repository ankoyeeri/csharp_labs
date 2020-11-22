using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Lab02.Ex2
{
    class Ex2_2b
    {
        public static void Start()
        {
            string firstStroke = "123456";
            string secondStroke = "Hello World Hello2 World2";
            string thirdStroke = "6k5k4-g3k2k1j";

            // Конкатенация (слияние) строк
            string resultStroke = String.Concat(firstStroke, secondStroke, thirdStroke);
            Console.WriteLine($"Concatenation: {resultStroke}");

            Console.WriteLine("Copy is now obsolete");

            resultStroke = thirdStroke.Substring(5);
            Console.WriteLine($"Substring: {resultStroke}");

            string[] words = secondStroke.Split(new char[] { ' ' });
            Console.WriteLine("\nSplit stroke:");
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            resultStroke = firstStroke.Insert(5, secondStroke);
            Console.WriteLine($"\nInstert: {resultStroke}");

            resultStroke = secondStroke.Remove(5);
            Console.WriteLine($"Remove: {resultStroke}");
        }
    }
}
