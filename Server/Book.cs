using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class Book
    {
        private int bookID;
        private int clientID;
        private BookInfo info = new BookInfo();
        private Status status = new Status();

        public Book(int bookID, int clientID, BookInfo info, Status status)
        {
            this.bookID = bookID;
            this.clientID = clientID;
            this.info = info;
            this.status = status;
        }

        public Book(){ }

        public int BookID { get => bookID; set => bookID = value; }
        public BookInfo Info { get => info; set => info = value; }
        public Status Status { get => status; set => status = value; }
        public int ClientID { get => clientID; set => clientID = value; }
    }
}