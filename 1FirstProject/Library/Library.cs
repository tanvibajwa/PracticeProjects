using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Library
    {
        public string library_name { get; }
        public List<Book> list_of_books { get; }

        public Library(string name, List<Book> books)
        {
            library_name = name;
            list_of_books = books;
        }

        public void add_book(Book new_book)
        {
            list_of_books.Add(new_book);
        }

        public List<Book> search_book(string author)
        {
            var books_of_particular_author = new List<Book> { };
            foreach (Book book in list_of_books)
            {
                if (book.author.ToLower() == author.ToLower())
                {
                    books_of_particular_author.Add(book);
                }
            }

            return books_of_particular_author;
        }

        public void display_book_info(uint isbn)
        {
            foreach (Book book in list_of_books)
            {
                if (book.ISBN_number == isbn)
                {
                    Debug.WriteLine("Title : " + book.title);
                    Debug.WriteLine("Author : " + book.author);
                    Debug.WriteLine("Publisher : " + book.publisher);
                    Debug.WriteLine("Release Date : " + book.release_date);
                    Debug.WriteLine("ISBN number : " + book.ISBN_number);
                    break;
                }
            }
        }

        public void delete_book(string author)
        {
            for (int i = 0; i < list_of_books.Count; i++)
            {
                if (list_of_books[i].author.ToLower() == author.ToLower())
                {
                    list_of_books.Remove(list_of_books[i]);
                }
            }
        }
    }
}
