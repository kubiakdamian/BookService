using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.BookServiceReference;

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
            PrintUserBooks(11);
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
            if (CheckIfUserExists(userID))
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
            else
            {
                Console.WriteLine("User with ID: " + userID + " doesn't exist\n");
            }
            
        }

        private static void PrintBookStatus(int bookID)
        {
            if (CheckIfBookExists(bookID))
            {
                try
                {
                    if (client.BorrowedBook(bookID).IsBorrowed)
                    {
                        Console.WriteLine("Book is already borrowed\n");
                    }
                    else
                    {
                        Console.WriteLine("Book can be borrowed\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Couldn't print data");
                }
            }
            else
            {
                Console.WriteLine("There is no book with id: " + bookID);
            }
            
            
        }

        private static bool CheckIfBookExists(int bookID)
        {
            bool exists = false;

            foreach (var book in client.ListOfBorrowedItems())
            {
                if(book.BookID == bookID)
                {
                    exists = true;
                }
            }

            return exists;
        }

        private static bool CheckIfUserExists(int userID)
        {
            bool exists = false;

            foreach (var book in client.GetBooks())
            {
                if (book.ClientID == userID)
                {
                    exists = true;
                }
            }

            return exists;
        }
    }
}
