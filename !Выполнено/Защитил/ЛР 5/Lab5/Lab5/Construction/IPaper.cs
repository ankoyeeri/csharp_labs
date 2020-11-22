using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab5.Construction
{
    interface IPaper
    {
        string Color { get; set; }
        void Note();
    }
}
