using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class BookInfo
    {
        private string info;
        private DateTime borrowDate;
        private DateTime returnDate;

        public BookInfo(string info, DateTime borrowDate, DateTime returnDate)
        {
            this.info = info;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
        }

        public BookInfo()
        {
        }

        public string Info { get => info; set => info = value; }
        public DateTime BorrowDate { get => borrowDate; set => borrowDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
    }
}