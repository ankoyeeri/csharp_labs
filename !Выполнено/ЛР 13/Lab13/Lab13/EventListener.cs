using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    abstract class EventListener
    {
        public delegate void Handler(string message);
    }
}
