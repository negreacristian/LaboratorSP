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
        private string ImageName;
        public Image() { } 
        public Image(string imageName)
        {
            this.ImageName = imageName;
        }

        public string GetImageName() { return ImageName; }
        public override void Print() { Console.WriteLine("Print image"); }
    }
}
