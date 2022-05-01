using System.Collections.Generic;

namespace Practice_Day_Books.Models
{
    class Library
    {
        private List<Book> _books = new List<Book>();

        public List<Book> FindAllBooksByName(string value)
        {
            return _books.FindAll(book => book.Name.Contains(value));
        }

        public void RemoveAllBooksByName(string name)
        {
            _books.RemoveAll(book => book.Name.Contains(name));
        }

        public List<Book> SearchBooks(string value)
        {
            return _books.FindAll(book => book.Name.Contains(value) || book.AuthorName.Contains(value) || book.PageCount.ToString().Contains(value));
        }

        public List<Book> FindAllBooksByPageCountRange(int minpage, int maxpage)
        {
            return _books.FindAll(book => book.PageCount >= minpage && book.PageCount <= maxpage);
        }

        public void RemoveBookByCode(string code)
        {
            Book book = _books.Find(book => book.Code == code);

            if (book != null)
            {
                _books.Remove(book);
            }
        }
    }
}
