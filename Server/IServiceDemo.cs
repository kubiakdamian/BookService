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
        string ListOfBorrowedItems();

        [OperationContract]
        string getBorrowedBooks(int userID);

        [OperationContract]
        BookInfo GetBookInfo(int bootID);

        [OperationContract]
        Status BorrowedBook(int bootID);
    }
}
