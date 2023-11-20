using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace C07Abstract
{
    internal class Movie : Medium
    {
        //public string Title { get; set; }
        public double Length { get; set; }
        public string FileName { get; set; }
        public override string Present()
        {
            return Title;
        }
        public override void Play() { Console.WriteLine("Bum"); }

    }
}
