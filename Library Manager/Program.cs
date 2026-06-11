using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager {
    internal class Program {

        class Book 
        {
            public string NameOfBook;
            public bool BookIsTook;
        }

        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            while (true)
            {
            Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Show Books");
                Console.WriteLine("3.Borrow Books");
                Console.WriteLine("4.Return Book");
                Console.WriteLine("5.Count Book");
                Console.WriteLine("6.Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Book book = new Book();

                    Console.WriteLine("Enter Your Book:");
                    book.NameOfBook = Console.ReadLine();

                    book.BookIsTook = false;

                    books.Add(book);
                }

                else if (choice == 2)
                {
                    for(int i = 0; i< books.Count; i++)
                    {
                        if (books[i].BookIsTook)
                        {

                            Console.WriteLine($"{i + 1}. {books[i].NameOfBook} [ x ]");
                        }
                        else
                        {
                            Console.WriteLine($"{i + 1}. {books[i].NameOfBook} [ ]");
                        }
                    }
                }

                else if (choice == 3)
                {

                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].BookIsTook)
                        {

                            Console.WriteLine($"{i + 1}. {books[i].NameOfBook} [ x ]");
                        }
                        else
                        {
                            Console.WriteLine($"{i + 1}. {books[i].NameOfBook} [ ]");
                        }
                    }
                       int choose = int.Parse(Console.ReadLine());
                        int index = choose - 1;
                        if(index >= 0 && index < books.Count)
                        {
                            books[index].BookIsTook = true;
                        }else
                        {
                            Console.WriteLine("Wrong Choice");
                        }
                }
                else if(choice == 4)
                {
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].BookIsTook)
                        {

                            Console.WriteLine($"{i + 1}. {books[i].NameOfBook} [ x ]");
                        }
                        else
                        {
                            Console.WriteLine($"{i + 1}. {books[i].NameOfBook} [ ]");
                        }
                    }
                        int choose = int.Parse(Console.ReadLine());
                        int index = choose - 1;
                        if(index >= 0 && index < books.Count)
                        {
                            books[index].BookIsTook = false;
                        }
                        else
                        {
                            Console.WriteLine("Wrong Choice");
                        }


                }
                else if (choice == 5)
                {
                    Console.WriteLine(books.Count);
                }
                else if (choice == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Choice");
                }
            }

        }
    }
}
