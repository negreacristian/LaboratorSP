using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLab
{
    internal class AlignRight : IAlignStrategy
    {
        public void Render(Paragraph paragraph)
        {
            Paragraph newParagraph = new Paragraph($"------{paragraph.Text}");
            paragraph.Text = newParagraph.Text;
        }
    }
}
