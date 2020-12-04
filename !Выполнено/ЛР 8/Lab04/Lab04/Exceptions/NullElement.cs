using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04.Exceptions
{
    class NullElement : Exception
    {
        public NullElement()
        {
            Console.WriteLine("Элемент является null");
        }
    }
}
