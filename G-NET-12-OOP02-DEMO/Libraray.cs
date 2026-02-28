using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP02_DEMO
{
    internal class Libraray
    {
        public string Name { get; }
        private List<Book> _Books = new List<Book>();
        public int BooksCount => _Books.Count;
        //------------------------
        public Libraray(string _Name)
        {
            Name = _Name;
        }
        //-----------------
        public void AddNewBook(Book book)
        {
            _Books.Add(book);
        }
        //-------------------------
        public Book? this[int index]
        {
            get
            {
                if (index >= 0 && index < _Books.Count)
                {
                    return _Books[index];
                }
                return null;

            }
        }
        //----------------------
        public Book? this[string Isbn]
        {
            get
            {
                foreach (var book in _Books)
                {
                    if (book.ISBN == Isbn)
                    {
                        return book;
                    }
                }
                return null;
            }
        }
    }
}
