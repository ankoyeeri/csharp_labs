using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab04
{
    class TypesWriter
    {
        public static void WriteType<T>(T element) where T : class
        {
            string filePath = "GenericTypes.txt";

           using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(element.GetType());
            }

            Console.WriteLine("Запись завершена!");
        }
    }
}
