using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    public class ServiceDemo : IServiceDemo
    {
        private List<Book> books = new List<Book>() {
            new Book(1, 1, new BookInfo("Pierwsza ksiazka", new DateTime(2014, 7, 11), new DateTime(2014, 10, 18)), new Status(true)),
            new Book(2, 0, new BookInfo("Druga ksiazka", new DateTime(2015, 8, 15), new DateTime(2015, 10, 26)), new Status(false))
        };

        public Status BorrowedBook(int bookID)
        {
            Book chosenBook = new Book();
            foreach (var book in books)
            {
                if (book.BookID == bookID)
                {
                    chosenBook = book;
                }
            }

            return chosenBook.Status;
        }

        public BookInfo GetBookInfo(int bookID)
        {
            Book chosenBook = new Book();
            foreach(var book in books)
            {
                if(book.BookID == bookID)
                {
                    chosenBook = book;
                }
            }

            return chosenBook.Info;
        }

        public List<Book> getBorrowedBooks(int userID)
        {
            List<Book> borrowedBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.ClientID == userID)
                {
                    borrowedBooks.Add(book);
                }
            }

            return borrowedBooks;
        }

        public List<Book> ListOfBorrowedItems()
        {
            List<Book> borrowedBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Status.IsBorrowed)
                {
                    borrowedBooks.Add(book);
                }
            }

            return borrowedBooks;
        }
    }
}
