using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

using Lab03;

namespace Lab11
{
    class ListFunctionCaller
    {
        public static void ListFirstFunction(List<House> list)
        {
            var result = list
                .Where(s => s.flatArea == 10)
                .Where(c => c.flatStreet.Equals("Test1"))
                .Select(w => "Номер квартиры: " + w.flatNumber + "\tЭтаж квартиры " + w.flatFloor + "\t\t" + w.flatStreet);


            Console.WriteLine("\nСписок отобран по критериям:\nПлощадь квартиры - 10. Адрес квартиры - Test1.\n");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
