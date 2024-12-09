using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryApp
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));
            _books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryEnumerator(_books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
