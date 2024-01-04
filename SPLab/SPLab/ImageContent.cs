using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLab
{
    internal class ImageContent
    {
        private string imageContent;
        public ImageContent(string url)
        {
            imageContent = $"imageContent fom {url}";
        }

        public ImageContent GetImageContent() { return this; }
    }
}
