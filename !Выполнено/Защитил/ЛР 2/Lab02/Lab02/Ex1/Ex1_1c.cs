using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Lab02
{
    public class Ex1_1c
    {
        public static void Start()
        {
            // Упаковка-распаковка значимых типов
            int varInt = 555;
            object obj = varInt;
            int newVarInt = (int)obj;

            Console.WriteLine($"Boxing and unboxing: {newVarInt}");
        }
    }
}
