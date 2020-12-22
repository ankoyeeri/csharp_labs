using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Lab11
{
    class LinqRequest
    {
        /// <summary>
        /// Покупатели в алфавитном порядке
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void BuyersInAlphabet(List<Buyer> list)
        {
            var result = from l in list
                         orderby l.Name
                         select l;

            Console.WriteLine("\nВывод в алфавитном порядке:");
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }

        /// <summary>
        /// Покупатели в определенном диапазоне
        /// </summary>
        /// <param name="list"></param>
        public static void BuyersCardInterval(List<Buyer> list)
        {
            int start = 300000;
            int end = 399999;

            var result = from l in list
                         where l.CardNumber > start && l.CardNumber < end
                         select l;


            Console.WriteLine($"\nВывод покупателем с диапазоном карты от {start} до {end}");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name}    { item.CardNumber}");
            }
        }

        /// <summary>
        /// Максимальный покупатель
        /// </summary>
        /// <param name="list"></param>
        public static void MaxBuyer(List<Buyer> list)
        {
            //var result = from l in list
            //             orderby list.OrderBy(p => p.Balance).FirstOrDefault()
            //             select l;

            var result = list.Aggregate((i1, i2) => i1.Balance > i2.Balance ? i1 : i2);

            Console.WriteLine($"\nМаксимальный покупатель");
            Console.WriteLine($"{result.Name}\t\t{result.CardNumber}\t\t{result.Balance}");
        }

        public static void FiveMaxBuyers(List<Buyer> list)
        {
            //var result = list.OrderBy(p => p.Balance).FirstOrDefault();
            var result = list.Where(p => p.Balance > 0).OrderByDescending(x => x.Balance).Take(5);
            Console.WriteLine("\nПервые пять покупателей");
            foreach(var item in result)
            {
                Console.WriteLine($"{item.Name}             {item.Balance}");
            }    
        }
    }
}
