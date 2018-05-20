using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    [ServiceContract]
    public interface IServiceDemo
    {
        [OperationContract]
        List<Book> ListOfBorrowedItems();

        [OperationContract]
        List<Book> getBorrowedBooks(int userID);

        [OperationContract]
        BookInfo GetBookInfo(int bookID);

        [OperationContract]
        Status BorrowedBook(int bookID);

        [OperationContract]
        List<Book> GetBooks();
    }
}
