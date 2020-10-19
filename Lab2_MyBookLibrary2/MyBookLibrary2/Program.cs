using System;
using MyBookLibrary;

namespace MyBookLibrary2
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList bl = new BookList();
            int choice;
            do
            {
                Console.WriteLine("-------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. List");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string id;
                        do
                        {
                            Console.Write("ID: ");
                            id = Console.ReadLine();
                            if (!bl.checkID(id))
                                Console.WriteLine("Exist id! Try again: ");
                        } while (!bl.checkID(id));
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Publisher: ");
                        string publisher = Console.ReadLine();
                        Console.Write("Price: ");
                        string price = Console.ReadLine();
                        bl.add(new Book(id, name, publisher, price));
                        Console.WriteLine("Add success!");
                        break;
                    case 2:
                        Book b = bl.getBookByID();
                        if (b != null)
                        {
                            bl.update(b);
                            Console.WriteLine("Update Success!");
                        }
                        else Console.WriteLine("Can't find this book!");
                        break;
                    case 3:
                        Book bo = bl.getBookByID();
                        if (bo != null)
                        {
                            Console.Write("Do you want to delete this book?(y/n): ");
                            string s = Console.ReadLine();
                            if (s == "y")
                            {
                                bl.delete(bo);
                                Console.WriteLine("Delete Success!");
                            }
                        }
                        else
                            Console.WriteLine("Can't find this book!");
                        break;
                    case 4:
                        if (bl.Lb.Count <= 0) Console.WriteLine("The List is empty!");
                        else
                        {
                            bl.list();
                            Console.WriteLine("List all book success!");
                        }
                        break;
                }
            } while (choice < 5 && choice > 0);
            Console.ReadLine();
        }
    }
}
