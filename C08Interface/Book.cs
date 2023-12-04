using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08Interface
{
    internal class Book : Paper, IReadable, IComparable<Book>
    {
        public Book(string name, string content)
        {
            Name = name;
            Content = content;
        }

        public string Name { get; private set; }
        public string Content { get; private set; }
        public int PageCount { get { return Content.Split(" ").Count(); } }

        public int CompareTo(Book? other)
        {
            if(other is not null)
            {
                return PageCount.CompareTo(other.PageCount);
            }
            return 1;
        }

        public string Read()
        {
            return Content;
        }
    }
}
