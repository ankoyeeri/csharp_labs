using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Exceptions
{
    class DBZException : Exception
    {
        public DBZException()
            : base("Деление на 0")
        {

        }
    }
}
