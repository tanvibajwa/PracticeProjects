using System.Collections.Generic;
using System.Collections;
using System;

using NUnit.Framework;

using LibraryProject;

namespace Tests
{
    public class Tests
    {
        public Library library;

        [SetUp]
        public void Setup()
        {
            List<Book> books = new List<Book> { };
            library = new Library("Brampton Library", books);
            var book1 = new Book("2 States", "Chetan Bhagat", "CompanyA", new DateTime(2012, 11, 22), 111);
            var book2 = new Book("PS I love you", "Mainu ni pta", "CompanyB", new DateTime(2012, 11, 24), 112);
            var book3 = new Book("Harry Potter", "Smart Lady", "CompanyC", new DateTime(2012, 11, 25), 113);

            library.add_book(book1);
            library.add_book(book2);
            library.add_book(book3);
        }

        [Test]
        public void Test1()
        {
            library.display_book_info(111);
            library.display_book_info(112);
            library.display_book_info(113);
        }

        [Test]
        public void Test2()
        {
            library.delete_book("Chetan Bhagat");
            var result = library.search_book("Chetan Bhagat");
            Assert.That(result.Count == 0);
        }
    }
}