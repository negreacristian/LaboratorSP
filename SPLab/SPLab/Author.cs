using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SPLab
{
    public class Author
    {
        private string name;

        public Author() { }
        public Author(string name) { this.name = name; }

        public string GetName(string name) { return name; } 
        public void SetName(string name) { this.name = name; }

        public void Print() { Console.Write(this.name); }

        internal string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
