using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Lab04
{

    class Program
    {
        //  Вариант 4
        static void Main(string[] args)
        {
            var collection1 = new Set<int>() { 1, 5, 2, 8, 3 };
            var collectionUn = new Set<int>() { 4, 2, 5, 8, 7 };

            var collection2 = new Set<int>() { 4, 6, 9, 7, 0 };
            var collection3 = new Set<int>() { 1, 2, 3 };
            var collectionStr = new Set<string>() { "test", "123", null, "here_must_be_a_dot" };

            //---------------------------------------------
            // Extension Method 1
            String str = "There must be dot in the end";
            Console.WriteLine("Extension method 1: " + str.DotInTheEnd());
            //---------------------------------------------

            //---------------------------------------------
            //  Extension Method 2
            var listWithNull = new List<string>() { "test", "123", null, "peepo" };
            listWithNull.RemoveAllNull();
            Console.WriteLine("\n\nExtennsion method 2:");
            foreach (var item in listWithNull)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nДлина: " + listWithNull.Count());
            //---------------------------------------------

            //---------------------------------------------
            // Проверка метода статического класса
            StatisticOperation.Sum(collection1);
            StatisticOperation.Difference(collection1);
            StatisticOperation.Count(collection1);
            Console.WriteLine(StatisticOperation.DotInTheEnd_ext("В конце должна стоять точка"));

            var list5 = new List<string>() { "test", "TEST", null, "Peepo", null, ":--D" };
            StatisticOperation.RemoveAllNull_ext(list5);
            foreach (var item in list5)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nДлина: " + list5.Count);
            //---------------------------------------------

            //---------------------------------------------
            //  Вложенный объект
            Set<int>.Owner owner = new Set<int>.Owner();
            Console.WriteLine("\n\nИнициализация вложенного объекта");
            owner.Id = 1;
            owner.Name = "Sam";
            owner.OrgName = "Sony Inc.";
            Console.WriteLine("Id: " + owner.Id);
            Console.WriteLine("Name: " + owner.Name);
            Console.WriteLine("OrgName: " + owner.OrgName);
            //---------------------------------------------

            var res2 = collection1 & collectionUn;  //  Объединение

            Console.WriteLine("\n\nUnion:");
            foreach (int item in res2)
            {
                Console.Write($"{item} ");
            }


            collection1.Add(7);     //  Добавление элемента

            Console.WriteLine("\n\ncollection1:");
            foreach (int item in collection1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n\ncollection2:");
            foreach (int item in collection2)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n\ncollection3:");
            foreach (int item in collection3)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n\nДобавление элемента в collection1: ");
            foreach (int item in collection1)
            {
                Console.Write($"{item} ");
            }

            collection1 -= 7;       //  Удаление элемента

            Console.WriteLine("\n\nУдаление элемента из collection1: ");
            foreach (int item in collection1)
            {
                Console.Write($"{item} ");
            }

            var resCollection1 = collection1 * collection2;

            Console.WriteLine("\n\nПересечение множеств:");
            foreach (int item in collection1)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n\nПроверка на подмножество 3 и 1: {collection3 > collection1}");

            Console.WriteLine($"\n\nПроверка на равенство множеств 3 и 2: {collection3 < collection2}");

            Console.WriteLine("\n\ncollection2: ");
            foreach (int item in collection2)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
