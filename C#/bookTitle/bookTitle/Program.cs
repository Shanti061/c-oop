using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            char response;
            string addBook;
            string removeBook;
            List<string> bookList = new List<string>() { "The Alchemist", "Zahir", "2 States" };
            Console.WriteLine("Enter 'L' to list the books name, 'A' to add new book name, 'D' to delete a book, 'S' to sort the book  or 'X' to exit. ");
            response = Convert.ToChar(Console.ReadLine().ToUpper());


            do
            {
                switch (response)
                {
                    case 'L':
                        foreach (string book in bookList)
                        {
                            Console.WriteLine(book);
                            Console.WriteLine();
                        }
                       
                        break;

                    case 'A':

                        Console.WriteLine("Enter a book name to add in the list. ");
                        addBook = Console.ReadLine();
                        bookList.Add(addBook);
                        break;

                    case 'D':
                        Console.WriteLine("Write the name of the book you would like to delete.");
                        removeBook = Console.ReadLine();
                        bookList.Remove(removeBook);
                        break;

                    case 'S':
                        Console.WriteLine("The book list is being sorted alphabetically now...");
                        bookList.Sort();

                        foreach (string book in bookList)
                        {
                            Console.WriteLine(book);
                            Console.WriteLine();
                        }
                        break;

                        //another way of listing value
                        //bookList.ForEach(Console.WriteLine);


                    //for loop to list
                        //for (int i = 0; i < bookList.Count; i++) {
                           // Console.WriteLine(bookList[i]);
                        //}

                        default:
                        //Console.WriteLine("Enter 'L' to list the books name, 'A' to add new book name or 'X' to exit. ");
                        break;

                }
                Console.WriteLine("Enter 'L' to list the books name, 'A' to add new book name, 'S' to sort the book or 'X' to exit. ");
                response = Convert.ToChar(Console.ReadLine().ToUpper());
            } while (response != 'X');
        }
    }
}
