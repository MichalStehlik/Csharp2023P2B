using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07Abstract
{
    internal class Book : Medium
    {
        //public string Title { get; set; }
        public string Author { get; set; }
        public int PagesCount { get; set; }
        public override string Present()
        {
            return Title;
        }
        public override void Play() { Console.WriteLine("ssssss"); }
    }
}
