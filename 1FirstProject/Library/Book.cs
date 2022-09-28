using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Book
    {
        public string title { get; }
        public string author { get; }
        public string publisher { get; }
        public DateTime release_date { get; }
        public uint ISBN_number { get; }

        public Book(string book_title, string book_author, string book_publisher, DateTime book_release_date, uint book_ISBN_number)
        {
            title = book_title;
            author = book_author;
            publisher = book_publisher;
            release_date = book_release_date;
            ISBN_number = book_ISBN_number;
        }
    }
}
