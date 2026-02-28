using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP02_DEMO
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Book(string _ISBN, string _Title)
        {
            ISBN = _ISBN;
            Title = _Title;
        }
    }
}
