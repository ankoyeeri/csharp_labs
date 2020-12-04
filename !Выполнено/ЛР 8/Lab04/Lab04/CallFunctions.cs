using System;
using System.Collections.Generic;
using Lab04.Exceptions;

namespace Lab04
{
    class CallFunctions
    {
        public static void Menu()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("1) CallExtMethod1\n2) CallExtMethod2\n3) CallShowList\n" +
                                   "4) CallStaticClasses\n5) IncludedObj\n6) CallUnion\n7) CallAdd\n" +
                                   "8) CallDeleteElement\n9) CallCross\n10) CallCheck\n");
                    int choise = Convert.ToInt32(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            CallExtMethod1();
                            break;
                        case 2:
                            CallExtMethod2();
                            break;
                        case 3:
                            CallShowList();
                            break;
                        case 4:
                            CallStaticClasses();
                            break;
                        case 5:
                            IncludedObj();
                            break;
                        case 6:
                            CallUnion();
                            break;
                        case 7:
                            CallAdd();
                            break;
                        case 8:
                            CallDeleteElement();
                            break;
                        case 9:
                            CallCross();
                            break;
                        case 10:
                            CallCheck();
                            break;
                    }
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            catch (BadFormat e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Выполнение завершено");
            }
            
        }


        public static void CallExtMethod1()
        {
            String str = "There must be dot in the end";
            Console.WriteLine("Extension method 1: " + str.DotInTheEnd());
        }

        public static void CallShowList()
        {
            var collection1 = new Set<int>() { 1, 5, 2, 8, 3 };

            collection1.ShowList();
        }

        public static void CallExtMethod2()
        {
            var listWithNull = new List<string>() { "test", "123", null, "peepo" };
            listWithNull.RemoveAllNull();
            Console.WriteLine("\n\nExtennsion method 2:");
            foreach (var item in listWithNull)
            {
                Console.Write($"{item} ");
            }
            //Console.WriteLine("\nДлина: " + listWithNull.Count());
        }

        public static void CallStaticClasses()
        {
            var collection1 = new Set<int>() { 1, 5, 2, 8, 3 };
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
        }

        public static void IncludedObj()
        {
            Set<int>.Owner owner = new Set<int>.Owner();
            Console.WriteLine("\n\nИнициализация вложенного объекта");
            owner.Id = 1;
            owner.Name = "Sam";
            owner.OrgName = "Sony Inc.";
            Console.WriteLine("Id: " + owner.Id);
            Console.WriteLine("Name: " + owner.Name);
            Console.WriteLine("OrgName: " + owner.OrgName);
        }

        public static void CallUnion()
        {
            var collection1 = new Set<int>() { 1, 5, 2, 8, 3 };
            var collectionUn = new Set<int>() { 4, 2, 5, 8, 7 };

            var res2 = collection1 & collectionUn;  //  Объединение

            Console.WriteLine("\n\nUnion:");
            foreach (int item in res2)
            {
                Console.Write($"{item} ");
            }
        }

        public static void CallAdd()
        {
            var collection1 = new Set<int>() { 1, 5, 2, 8, 3 };
            collection1.Add(7);     //  Добавление элемента

            Console.WriteLine("\n\ncollection1:");
            foreach (int item in collection1)
            {
                Console.Write($"{item} ");
            }
        }

        public static void CallDeleteElement()
        {
            var collection1 = new Set<int>() { 1, 5, 2, 8, 3 };

            collection1 -= 7;       //  Удаление элемента

            Console.WriteLine("\n\nУдаление элемента из collection1: ");
            foreach (int item in collection1)
            {
                Console.Write($"{item} ");
            }
        }

        public static void CallCross()
        {
            var collection1 = new Set<int>() { 1, 5, 2, 8, 3 };
            var collection2 = new Set<int>() { 4, 6, 9, 7, 0 };

            var resCollection1 = collection1 * collection2;

            Console.WriteLine("\n\nПересечение множеств:");
            foreach (int item in collection1)
            {
                Console.Write($"{item} ");
            }
        }

        public static void CallCheck()
        {
            var collection1 = new Set<int>() { 1, 5, 2, 8, 3 };
            var collectionUn = new Set<int>() { 4, 2, 5, 8, 7 };

            var collection2 = new Set<int>() { 4, 6, 9, 7, 0 };
            var collection3 = new Set<int>() { 1, 2, 3 };

            Console.WriteLine($"\n\nПроверка на подмножество 3 и 1: {collection3 > collection1}");

            Console.WriteLine($"\n\nПроверка на равенство множеств 3 и 2: {collection3 < collection2}");
        }

    }
}
