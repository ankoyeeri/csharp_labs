using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14.Construction
{
    [Serializable]
    public abstract class Plant
    {
        public string Name { get; set; }
        public virtual double Size { get; set; }

        public abstract void Note();
    }
}
