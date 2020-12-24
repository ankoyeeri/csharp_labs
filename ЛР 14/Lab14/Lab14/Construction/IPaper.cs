using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab14.Construction
{
    interface IPaper
    {
        string Color { get; set; }
        void Note();
    }
}
