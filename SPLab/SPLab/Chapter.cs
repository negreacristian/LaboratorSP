using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SPLab
{
    public class Chapter
    {
        private string name;
        private List<SubChapter> sub_Chapters = new List<SubChapter>();

        Chapter(Chapter other) { this.name = other.name; }
        public Chapter() { }
        public Chapter(string name)
        {
            this.name = name;
        }   
        
        public string GetName() {  return name; }
        public void SetName(string name) { this.name = name; }

        public int CreateSubChapter(string subChapterName)
        {
            this.sub_Chapters.Add(new SubChapter(subChapterName));
            return sub_Chapters.Count;
        }

        public SubChapter GetSubChapter(int index) { return sub_Chapters[index - 1]; }
    }
}
