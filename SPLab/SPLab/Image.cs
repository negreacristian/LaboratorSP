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
        private string url;
        private ImageContent content;
        
            
        public Image(string _url) {
            url = _url;
            content = new ImageContent(url);
        }
        
        public override void Add(Element element)
        {
            //throw new NotImplementedException();
        }

        public override void Remove(Element element)
        {
            throw new NotImplementedException();
        }

        public ImageContent Content() 
        { 
            return content.GetImageContent(); 
        }

        public override Element Get(int index)
        {
            throw new NotImplementedException();
        }

        public override void Print() { Console.WriteLine(url); }

    }
}
