using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03OOP
{
    internal class Book // třída
    {
        private string name; // atribut, datový člen
        private string _author; // vhodná konvence

        public string GetName() // metoda
        {
            return name;
        }

        public void SetName(string name)
        {
            if (name.Length < 2)
            {
                this.name = name;
            }
        }

        public string GetAuthor() // metoda
        {
            return _author;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public string GetTitle()
        {
            return _author + ": " + name;
        }
        // implicitní konstruktor
        public Book(string name, string author = "?") // parametrický konstruktor
        {
            //this.name = name;
            //_author = author;
            SetName(name);
            SetAuthor(author);
        }
        /*
        public Book(string name) // parametrický konstruktor, nahrazený implicitními parametry
        {
            this.name = name;
            _author = "?";
        }
        */
        public Book() // bezparametrický konstruktor
        {
            this.name = "?";
            _author="?";
        }

        ~Book() // desktruktor
        { 
            // do something
        }
    }
}
