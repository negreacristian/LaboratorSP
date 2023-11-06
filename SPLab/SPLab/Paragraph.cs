using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLab
{
    internal class Paragraph : Element
    {
        private string text;

        public Paragraph() { }
        public Paragraph(string text)
        {
            this.text = text;
        }
        public string GetText() {  return text; }
        public override void Print() { Console.WriteLine(text); }
    }
}
