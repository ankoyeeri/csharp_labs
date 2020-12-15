using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Exceptions
{
    class HashtableKeysIsEmptyException : Exception
    {
        public HashtableKeysIsEmptyException() : base("Таблица не заполнена")
        {
            Console.WriteLine(Message);
        }
    }
}
