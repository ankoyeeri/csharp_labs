using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lab03;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            //  1 Задание
            string[] months = {
                "June", "July", "August" , "September",
                "October", "November", "December", "January",
                "February", "March", "April", "May"
            };

            Console.WriteLine($"\nЗадание {count++}");
            //StringFunctionCaller.StringFirstMethod(months);
            //StringFunctionCaller.StringSecondMethod(months);
            //StringFunctionCaller.StringThirdMethod(months);
            //StringFunctionCaller.StringFrthMethod(months);


            //  2 Задание
            List<House> houses = new List<House>()
            {
                new House {flatNumber = 1, flatArea = 10, flatFloor = 8, flatRoomQuant = 1, flatStreet = "test1", flatLifetime = DateTime.Now},
                new House {flatNumber = 2, flatArea = 12, flatFloor = 7, flatRoomQuant = 4, flatStreet = "test2", flatLifetime = DateTime.Now},
                new House {flatNumber = 3, flatArea = 10, flatFloor = 6, flatRoomQuant = 2, flatStreet = "Test1", flatLifetime = DateTime.Now},
                new House {flatNumber = 4, flatArea = 20, flatFloor = 5, flatRoomQuant = 1, flatStreet = "Test3", flatLifetime = DateTime.Now},
                new House {flatNumber = 5, flatArea = 10, flatFloor = 4, flatRoomQuant = 1, flatStreet = "Test1",flatLifetime = DateTime.Now},
                new House {flatNumber = 6, flatArea = 10, flatFloor = 3, flatRoomQuant = 3, flatStreet = "Test1", flatLifetime = DateTime.Now},
                new House {flatNumber = 7, flatArea = 11, flatFloor = 2, flatRoomQuant = 4, flatStreet = "EEEEE", flatLifetime = DateTime.Now},
                new House {flatNumber = 8, flatArea = 27, flatFloor = 1, flatRoomQuant = 3, flatStreet = "Tesst", flatLifetime = DateTime.Now}
            };

            Console.WriteLine($"\nЗадание {count++}");
            //ListFunctionCaller.ListFirstFunction(houses);


            //  Задание 3
            List<Buyer> buyers = new List<Buyer>()
            {
                new Buyer { Name = "Михаил",    CardNumber = 794274, Balance = 150  },
                new Buyer { Name = "Анастасия", CardNumber = 312993, Balance = 954  },
                new Buyer { Name = "Сергей",    CardNumber = 666228, Balance = 666  },
                new Buyer { Name = "Вячеслав",  CardNumber = 921801, Balance = 439  },
                new Buyer { Name = "Виталий",   CardNumber = 394837, Balance = 1000 },
                new Buyer { Name = "Александра",CardNumber = 794274, Balance = 635  },
            };

            Console.WriteLine($"\nЗадание {count++}");
            //LinqRequest.BuyersInAlphabet(buyers);
            //LinqRequest.BuyersCardInterval(buyers);
            //LinqRequest.MaxBuyer(buyers);
            //LinqRequest.FiveMaxBuyers(buyers);


            //  Задание 4

            var request = months.Where(p => p.Any(w => p.StartsWith('J'))).OrderByDescending(p => p.Length).Select((p, i) => $"{i++})" + p);

            Console.WriteLine($"\nЗадание {count++}");
            foreach (var item in request)
            {
                Console.WriteLine($"{item}");
            }

            //Задание 5
            string[] countries = { "Беларусь", "Литва", "Норвегия", "Швейцария", "Австралия" };
            int[] key = { 1, 4, 6, 8 };
            var countrRequest = countries.Join(key, w => w.Length, q => q, (w,q) => new { country = w, id = q });

            Console.WriteLine($"\nЗадание {count++}");
            foreach (var item in countrRequest)
            {
                Console.WriteLine(item);
            }
        }
    }
}
