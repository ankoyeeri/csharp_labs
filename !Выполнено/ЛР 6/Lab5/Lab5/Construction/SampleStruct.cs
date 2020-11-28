using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Construction
{
    struct SampleStruct
    {
        public int filed1;
        public string field2;
        private int field3;
        public double field4;

        public SampleStruct(int a, string b, double d)
        {
            this.filed1 = a;
            this.field2 = b;
            this.field3 = 5;
            this.field4 = d;
        }

        //public SampleStruct()
        //{
        //    this.filed1 = 1;
        //    this.field2 = "test";
        //    this.field3 = 2;
        //    this.field4 = 2.2;
        //}
    }
}
