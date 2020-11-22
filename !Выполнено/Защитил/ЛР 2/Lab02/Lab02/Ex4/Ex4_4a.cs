using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace Lab02.Ex4
{
    class Ex4_4a
    {
        public static void Start()
        {
            //  Инициализация кортежа
            (int, string, char, string, ulong) tuple = (12, "Test", 'S', "HelloWorld", 1123321);

            //Вывод кортежа полностью
            Console.WriteLine(tuple);

            //  Вывод кортежа выборочно
            Console.WriteLine($"{tuple.Item1} {tuple.Item4} {tuple.Item3}");

            //  Распаковка кортежа в переменные
            //var intVar = tuple.Item1;
            //var stringVar1 = tuple.Item2;
            //var charVar = tuple.Item3;
            //var stringVar2 = tuple.Item4;
            //var ulongVar = tuple.Item5;

            var (num, stringVar, charVar, stringVar2, ulongVar) = tuple;
            Console.WriteLine(num);

            //  Сравнение двух кортежей

            var firstTuple = (9, 9);
            var secondTuple = (9, 9);

            if (firstTuple == secondTuple)
            {
                Console.WriteLine("firstTuple = secondTuple");
            }
            else
            {
                Console.WriteLine("Кортежи не равны");
            }
        }
    }
}
