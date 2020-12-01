using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Exceptions
{
    class ArgNullException : Exception
    {
        public ArgNullException()
        {

        }

        public ArgNullException(string name) : base($"Переменная {name} имеет значение null")
        {
        }
    }
}
