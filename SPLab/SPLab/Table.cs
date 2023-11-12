using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLab
{
    internal class Table : Element
    {
        public string title;
        public Table() { }
        public Table(string title) { this.title = title; }

        public override void Add(Element element)
        {
            throw new NotImplementedException();
        }

        public override Element Get(int index)
        {
            throw new NotImplementedException();
        }

        public string GetTitle() { return title; }

        public override void Print() { Console.WriteLine($"Table title: {title}"); }

        public override void Remove(Element element)
        {
            throw new NotImplementedException();
        }
    }
}
