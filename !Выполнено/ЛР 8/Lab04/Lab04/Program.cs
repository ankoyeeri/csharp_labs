using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Lab5.Construction;

namespace Lab04
{

    class Program
    {
        //  Вариант 4
        static void Main(string[] args)
        {
            var collection1 = new Set<int>() { 1, 5, 2, 8, 3 };
            var collectionComp = new Set<int>() { 1, 5, 2, 8, 3 };
            var collectionUn = new Set<int>() { 4, 2, 5, 8, 7 };

            var collection2 = new Set<int>() { 4, 6, 9, 7, 0 };
            var collection3 = new Set<int>() { 1, 2, 3 };
            var collectionStr = new Set<string>() { "test", "123", null, "here_must_be_a_dot" };


            //CallFunctions.Menu();

            //GenericClass.Comparator(collection1, collectionComp);

            Flower flower = new Flower();
            Flower flower1 = new Flower();

            flower.Name = "Test1";
            flower.Size = 10;
            flower1.Name = "Test2";
            flower1.Size = 5;

            GenericClass.Comparator(flower, flower1);
            Console.WriteLine(collection1.Equals(collectionComp));

            var flowers = new Set<Flower>
            {
                new Flower {Name = "Test1", Size = 10},
                new Flower {Name = "Test2", Size = 5}
            };


            TypesWriter.WriteType(flowers);


            Console.ReadLine();
        }
    }

    class GenericClass
    {
        public static void Comparator<T>(T a, T b) where T : class
        {
            Console.WriteLine(a.Equals(b));
        }
    }
}
