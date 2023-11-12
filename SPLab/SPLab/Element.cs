using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLab
{
    internal abstract class Element
    {
        public abstract void Add(Element element);
        public abstract void Remove(Element element);
        public abstract Element Get(int index);
        public abstract void Print();
    }
}
