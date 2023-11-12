using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLab
{
    internal class Section : Element

      {
        private string title;
        public string Title { get { return title; } 
                              set { title = value; } 
                            }

        public List<Element> elements = new List<Element>();
        public Section() { }
        public Section(string title) { this.title = title; }

        public override void Add(Element element)
        {

            elements.Add(element);
        }

        public override void Remove(Element element)
        {
            if (element is Section section)
            {
                elements.Remove(section);
            }
            else
            {
                // Handle removing non-section elements if needed
            }
        }

        public override Element Get(int index)
        {
            if (index >= 0 && index < elements.Count)
            {
                return elements[index];
            }
            else
            {
                return null;
            }
        }

        public override void Print()
        {
            Console.WriteLine(Title);
            foreach (var element in elements)
            {
                element.Print();
            }
        }
    }


}
