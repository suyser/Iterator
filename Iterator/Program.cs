namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем книги
            Book book1 = new Book("1984", "George Orwell", 1949);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);
            Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);

            // Создаем библиотеку и добавляем книги
            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            // Итерация по библиотеке
            Console.WriteLine("Books in the library:");
            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}
