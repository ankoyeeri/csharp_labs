using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Exceptions
{
    /// <summary>
    /// Исключение: Неверный формат
    /// </summary>
    class IncorrectValueException : Exception
    {
        public IncorrectValueException()
        {

        }

        public IncorrectValueException(string name)
            : base($"Неверно заданный формат: {name}")
        {

        }
    }
}
