using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SPLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book OSeara = new Book("Noapte buna, copii!");
            Author NC = new Author("Negrea Cristian");

            OSeara.AddAuthor(NC);

            Section cap1 = new Section("Capitolul 1");
            Section cap11 = new Section("Capitolul 1.1");
            Section cap111 = new Section("Capitolul 1.1.1");
            Section cap1111 = new Section("Subchapter 1.1.1.1");

            OSeara.AddContent(new Paragraph("Multumesc celor care ..."));
            OSeara.AddContent(cap1);

            cap1.Add(new Paragraph("Moto capitol"));
            cap1.Add(cap11);
            cap11.Add(new Paragraph("Text from subchapter 1.1"));
            cap11.Add(cap111);
            cap111.Add(new Paragraph("Text from subchapter 1.1.1"));
            cap111.Add(cap1111);
            cap1111.Add(new Image("Image subchapter 1.1.1.1"));
            OSeara.Print();
        }
    }
}
