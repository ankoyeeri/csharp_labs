using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02.Ex2
{
    class Ex2_2d
    {
        public static void Start()
        {
            StringBuilder stringBuilder = new StringBuilder("Test string in String Builder");
            Console.WriteLine($"Stroke capacity: {stringBuilder.Capacity}");
            Console.WriteLine($"Stroke length: {stringBuilder.Length}");

            //Удаление определенной позиции
            stringBuilder.Remove(21, 1);
            Console.WriteLine(stringBuilder);

            //Добавление новых символов в начало и конец
            stringBuilder.Insert(0, "1");
            stringBuilder.Insert(29,"2");
            Console.WriteLine($"\nEdited stroke: {stringBuilder}");
        }
    }
}
