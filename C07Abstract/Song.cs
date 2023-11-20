using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07Abstract
{
    internal class Song : Medium
    {
        //public string Title { get; set; }
        public double Length { get; set; }
        public string Interpret { get; set; }
        public override string Present()
        {
            return "Song" + Title;
        }
        public override void Play() { Console.WriteLine("Lala"); }
    }
}
