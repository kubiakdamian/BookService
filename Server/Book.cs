using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class Book
    {
        private int BookID;
        private BookInfo info = new BookInfo();
        private Status status = new Status();

        public Book(int bookID, BookInfo info, Status status)
        {
            BookID = bookID;
            this.info = info;
            this.status = status;
        }
    }
}