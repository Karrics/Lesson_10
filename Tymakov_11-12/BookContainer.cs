using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_11_12
{
    internal class BookContainer
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void SortBooks(Comparison<Book> comparison)
        {
            books.Sort(comparison);
        }

        public void PrintBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}");
            }
        }
    }
}
