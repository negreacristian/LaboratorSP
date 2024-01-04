using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLab
{
    internal class ImageProxy : Element
    {
        private string url;
        private Image realImage;
        public ImageProxy(string _url) 
        {
            url = _url;
        }

        public override void Add(Element element)
        {
            //throw new NotImplementedException();
        }

        public override Element Get(int index)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine(url);
        }

        public override void Remove(Element element)
        {
            throw new NotImplementedException();
        }

        public Image LoadImage()
        {
            if (realImage == null)
            {
                realImage = new Image(url);
            }

            return realImage;
        }
    }
}
