using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    interface CommonInterface<T>
    {
        public void Add(T element);

        public void Remove(T element);

        public void ShowList();
    }
}
