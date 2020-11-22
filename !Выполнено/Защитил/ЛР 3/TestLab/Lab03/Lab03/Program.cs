using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace Lab03
{

    //    Создать массив объектов.Вывести:
    //      a) список квартир, имеющих заданное число комнат;
    //      b) список квартир, имеющих заданное число комнат и
    //          расположенных на этаже, который находится в заданном промежутке;
    class Program
    {
        static void Main(string[] args)
        {
            

            House house1 = new House(12);
            House house2 = new House(12);

            //house1.Area = 200;
            //Console.WriteLine("Демонстрация проверки вводимого значения: " + house1.Area);


            var flat = new { 
                flatNumber = 1, 
                flatArea = 2,
                flatFloor = 3,
                flatRooms = 4,
                flatStreet =  "Yakuba Kolasa",
                flatBuildingType = "House",
                flatSuitability = 2020
            };

            Console.WriteLine("Вывод значения анонимного типа: " + flat.flatStreet);

            Console.WriteLine("Сравнение house2 с house1: " + house2.Equals(house1));
            Console.WriteLine("Сравнение house1 с house2: " + house1.Equals(house2));

            Console.WriteLine("Получение типа класса с помощью GetType(): " + house1.GetType());

            Console.WriteLine("Convert.ToString(): " + Convert.ToString(house1.ID) + " " + house2.ID);

            House[] housearray = new House[3];

            while (true)    // Условия поиска
            {
                try
                {
                    for (int i = 0; i < housearray.Length; i++)
                    {
                        housearray[i] = new House(i);

                        Console.WriteLine($"{i+1}-й дом");

                        Console.Write("Введите Номер квартиры: ");
                        housearray[i].Number = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите Площадь: ");
                        housearray[i].Area = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите Этаж: ");
                        housearray[i].Floor = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите Количество комнат: ");
                        housearray[i].Rooms = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите Улица: ");
                        housearray[i].Street = Console.ReadLine();

                        Console.Write("Введите Год по истечению срока дома: ");
                        housearray[i].Suitability = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Clear();

                    while (true)
                    {
                        Console.WriteLine("1) Вывести список квартир, имеющих заданное число комнат");
                        Console.WriteLine("2) Вывести список квартир, имеющих заданное число комнат и расположенных на этаже в заданном промежутке");

                        Console.Write("---> ");
                        int choise = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        switch (choise)
                        {
                            case 1:
                                Console.Write("Сколько должно быть комнат: ");
                                int roomsNum = Convert.ToInt32(Console.ReadLine());
                                for(int i = 0; i < housearray.Length; i++)
                                {
                                    if(roomsNum == housearray[i].Rooms)
                                    {
                                        Console.WriteLine($"Квартира {i + 1}");
                                        Console.WriteLine($"Количество комнат: {housearray[i].Rooms}\n");
                                    }
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                Console.Write("Количество комнат: ");
                                int rooms = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Диапазон этажей: ");
                                Console.Write("Начальный этаж: ");
                                int firstFloor = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Конечный этаж: ");
                                int lastFloor = Convert.ToInt32(Console.ReadLine());

                                for(int i = 0; i < housearray.Length; i++)
                                {
                                    if(firstFloor <= housearray[i].Floor && housearray[i].Floor <= lastFloor && housearray[i].Rooms == rooms)
                                    {
                                        Console.WriteLine($"Квартира {i+1}");
                                        Console.WriteLine($"Количество комнат: {housearray[i].Rooms}");
                                        Console.WriteLine($"Этаж: {housearray[i].Floor}");
                                    }
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            default:
                                break;
                        }

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            Console.ReadKey();
        }
    }
}
