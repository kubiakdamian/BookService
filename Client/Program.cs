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
            PrintBookStatus(1);
            PrintBookStatus(51);

            Console.ReadLine();
            client.Close();
        }

        private static void PrintBorrowedElements()
        {
            try
            {
                foreach (var book in client.ListOfBorrowedItems())
                {
                    Console.WriteLine("Book ID: " + book.BookID);
                    Console.WriteLine("Info: " + book.Info.Info.ToString());
                    Console.WriteLine("Borrow date: " + book.Info.BorrowDate.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Return date: " + book.Info.ReturnDate.ToString("dd/MM/yyyy") + "\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't print data");
            }
            
        }

        private static void PrintUserBooks(int userID)
        {
            try
            {
                Console.WriteLine("User " + userID + " books:\n");
                foreach (var book in client.getBorrowedBooks(userID))
                {
                    Console.WriteLine("Book ID: " + book.BookID);
                    Console.WriteLine("Info: " + book.Info.Info.ToString());
                    Console.WriteLine("Borrow date: " + book.Info.BorrowDate.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Return date: " + book.Info.ReturnDate.ToString("dd/MM/yyyy" + "\n"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't print data");
            }
        }

        private static void PrintBookStatus(int bookID)
        {
            try
            {
                if (client.BorrowedBook(bookID).IsBorrowed)
                {
                    Console.WriteLine("Book is already borrowed\n");
                }
                else if (!client.BorrowedBook(bookID).IsBorrowed)
                {
                    Console.WriteLine("Book can be borrowed\n");
                }
                else
                {
                    Console.WriteLine("There is no book with id: " + bookID + "\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't print data");
            }
            
        }
    }
}
