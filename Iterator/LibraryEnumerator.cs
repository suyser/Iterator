using System.Collections;

namespace LibraryApp
{
    public class LibraryEnumerator : IEnumerator<Book>
    {
        private readonly List<Book> _books;
        private int _position = -1;

        public LibraryEnumerator(List<Book> books)
        {
            _books = books;
        }

        public Book Current
        {
            get
            {
                if (_position < 0 || _position >= _books.Count)
                    throw new InvalidOperationException();
                return _books[_position];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return _position < _books.Count;
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {
            // Ничего не нужно освобождать
        }
    }
}
