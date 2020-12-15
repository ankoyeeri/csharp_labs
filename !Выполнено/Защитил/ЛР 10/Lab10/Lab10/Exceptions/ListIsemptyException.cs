using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Exceptions
{
    class ListIsemptyException : Exception
    {
        public ListIsemptyException() : base ("Лист пустой")
        {

        }
    }
}
