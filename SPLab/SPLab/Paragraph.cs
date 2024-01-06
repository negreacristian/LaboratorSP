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
        private IAlignStrategy _alignStrategy;
        public string Text { get { return this.text; } set { this.text = value; } }
        public Paragraph() { }
        public Paragraph(string text)
        {
            this.text = text;
        }
        public void SetAlignStrategy(IAlignStrategy alignStrategy)
        {
            _alignStrategy = alignStrategy;
            _alignStrategy.Render(this);
        }
        public override void Print() { Console.WriteLine(text); }

        public override void Add(Element element)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Element element)
        {
             throw new NotImplementedException();
        }

        public override Element Get(int index)
        {
            return this;
        }
    }
}
