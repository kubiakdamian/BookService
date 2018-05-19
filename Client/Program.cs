using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.BookServiceReference3;

namespace Client
{
    class Program
    {
        private static ServiceDemoClient client = new ServiceDemoClient();
        static void Main(string[] args)
        {          
            Console.WriteLine(client.GetBookInfo(2).Info + "\n");
            PrintBorrowedElements();
            PrintUserBooks(1);
            Console.ReadLine();
            //client.Close();
        }

        private static void PrintBorrowedElements()
        {
            foreach(var book in client.ListOfBorrowedItems())
            {
                Console.WriteLine("Book ID: " + book.BookID);
                Console.WriteLine("Info: " + book.Info.Info.ToString());
                Console.WriteLine("Borrow date: " + book.Info.BorrowDate.ToString("dd/MM/yyyy"));
                Console.WriteLine("Return date: " + book.Info.ReturnDate.ToString("dd/MM/yyyy") + "\n");
            }
        }

        private static void PrintUserBooks(int userID)
        {
            Console.WriteLine("User " + userID + " books:\n");
            foreach (var book in client.getBorrowedBooks(userID))
            {
                Console.WriteLine("Book ID: " + book.BookID);
                Console.WriteLine("Info: " + book.Info.Info.ToString());
                Console.WriteLine("Borrow date: " + book.Info.BorrowDate.ToString("dd/MM/yyyy"));
                Console.WriteLine("Return date: " + book.Info.ReturnDate.ToString("dd/MM/yyyy"));
            }
        }
    }
}
