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
        private string surname;
        public string Name { get { return name; } set { name = value; } }
        public string SurName { get { return surname; } set { surname = value; } }

        public Author() { }
        public Author(string name) { this.name = name; }

        public void Print() { Console.Write(this.name); }
    }
}
