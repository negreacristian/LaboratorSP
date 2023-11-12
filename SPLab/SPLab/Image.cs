using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SPLab
{
    internal class Image : Element
    {
        private string imagename;
        public string ImageName { get { return imagename; } set { this.imagename = value; } }
        public Image() { }
        public Image(string imageName)
        {
            this.imagename = imageName;
        }


        public override void Print() { Console.WriteLine(imagename); }


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
            throw new NotImplementedException();
        }
    }
}
