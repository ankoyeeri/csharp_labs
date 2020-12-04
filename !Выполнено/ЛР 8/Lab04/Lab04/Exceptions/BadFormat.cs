using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04.Exceptions
{
    class BadFormat : Exception
    {
        public BadFormat(string messsage) : base(messsage)
        {

        }
    }
}
