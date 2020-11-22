using System;

using Lab02.Ex1;
using Lab02.Ex2;
using Lab02.Ex3;
using Lab02.Ex4;
using Lab02.Ex6;

namespace Lab02
{
    class Program
    {
        //public static void Start()
        static void Main(string[] args)
        {
            Ex6_6abc.Start();

            Console.ReadKey();
            Console.Clear();

            //-------------------
            // Ex 5

            int[] array = new int[] { 2, 1, 5, 4, 3 };
            string str = "Just a usual string";

            char firstLetter;
            firstLetter = str[0];

            Console.WriteLine(str);

            Console.WriteLine(Function(array, str));

            static (int maxElement, int minimalElement, int elementsSum, char firstLetter) Function(int[] array, string str)
            {

                var result = (maxElement: 0, minimalElement: 0, elementsSum: 0, firstLetter: ' ');

                //  Поиск масимального и минимального элемента массива

                result.minimalElement = array[0];
                result.maxElement = array[0];

                for (int i = 0; i < array.Length; i++)
                {
                    if (result.minimalElement > array[i])
                    {
                        result.minimalElement = array[i];
                    }
                    if (result.maxElement < array[i])
                    {
                        result.maxElement = array[i];
                    }
                }

                //  Сумма элементов массива
                int elementsSum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    result.elementsSum += array[i];
                }

                //  Определение первого символа строки

                result.firstLetter = str[0];

                return result;
            }

            //-------------------

            Console.ReadKey();
        }
    }
}
