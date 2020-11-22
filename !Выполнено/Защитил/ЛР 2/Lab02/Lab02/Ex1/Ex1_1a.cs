using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Lab02
{
    public class Ex1_1a
    {
        public static void Start()
        {
            bool varBool = true;
            byte varByte = 255;
            sbyte varSbyte = 127;
            char varChar = '\u0001';
            decimal varDecimal = 1.1e28m;
            double varDouble = 0.999;
            float varFloat = 5.444e-7f;
            int varInt = 787878;
            uint varUint = 4294967295;
            long varLong = -9223372036854775808;
            ulong varUlong = 18446744073709551615;
            short varsShort = -32768;

            object obj;
            string strVal = "Test";

            Console.WriteLine(varUint + "\n");

            while (true)
            {
                try
                {
                    //  Подставить значение
                    Console.Write("Input: ");
                    obj = Console.ReadLine();
                    Console.WriteLine(obj);

                    Console.ReadKey();
                    Console.Clear();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}
