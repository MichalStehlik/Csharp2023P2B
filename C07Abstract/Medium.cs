using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07Abstract
{
    internal abstract class Medium
    {
        public string Title { get; set; }
        public virtual string Present()
        {
            return Title;
        }

        public abstract void Play();
    }
}
