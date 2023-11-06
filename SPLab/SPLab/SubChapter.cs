using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SPLab
{
    public class SubChapter
    {
        private string name;
        private Element element;
        private List<Paragraph> paragraphs = new List<Paragraph>();
        private List<Image> images = new List<Image>();
        private List<Table> tables = new List<Table>();
        public SubChapter() { }
        public SubChapter(string name)
        {
            this.name = name;
        }

        public void Print()
        {
            Console.WriteLine($"Subchapter: {name}");
            foreach (var paragraph in paragraphs) { Console.WriteLine($"Paragraph: {paragraph.GetText()}"); }
            foreach(var image in images) { Console.WriteLine($"Image with name: {image.GetImageName()}"); }
            foreach(var table in tables) { Console.WriteLine($"Table with Title: {table.GetTitle()}"); }

        }

        public void CreateNewParagraph(string text) { paragraphs.Add(new Paragraph(text)); }
        public void CreateNewImage(string imageName) { images.Add(new Image(imageName)); }
        public void CreateNewTable(string tableName) {  tables.Add(new Table(tableName)); }
    }
}
