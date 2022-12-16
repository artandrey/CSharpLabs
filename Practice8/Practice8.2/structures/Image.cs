using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{
    internal class Image
    {
        public readonly string Title;
        public readonly string Content;

        public Image(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }

        public void ShowImage()
        {
            Console.WriteLine(this.Title);
            Console.WriteLine(this.Content);
        }
    }
}
