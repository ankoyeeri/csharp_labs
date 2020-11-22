using System;
using System.Collections.Generic;
using System.Text;

using Lab5.Exceptions;

namespace Lab5
{
    /// <summary>
    /// Проверка исключений
    /// </summary>
    class ErrorCaller
    {
        public static void Start()
        {
            try
            {
                ObjCaller.DefBouquet();

            }
            catch (IncorrectFormatException)
            {

                throw new IncorrectFormatException();
            }
        }
    }
}
