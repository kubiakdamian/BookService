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
            new Book(1, new BookInfo("Pierwsza ksiazka", new DateTime(2014, 7, 11), new DateTime(2014, 10, 18)), new Status(true)),
            new Book(2, new BookInfo("Druga ksiazka", new DateTime(2015, 8, 15), new DateTime(2015, 10, 26)), new Status(true))
        };

        public Status BorrowedBook(int bookID)
        {
            throw new NotImplementedException();
        }

        public BookInfo GetBookInfo(int bookID)
        {
            throw new NotImplementedException();
        }

        public string getBorrowedBooks(int userID)
        {
            throw new NotImplementedException();
        }

        public string ListOfBorrowedItems()
        {
            throw new NotImplementedException();
        }
    }
}
