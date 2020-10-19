using System;
using System.Collections;
using System.Text;

namespace MyBookLibrary
{
    public class BookList
    {
        ArrayList lb = new ArrayList();

        public ArrayList Lb { get => lb; set => lb = value; }
        public void add(Book b)
        {
            Lb.Add(b);           
        }
        public Book getBookByID()
        {
            Console.Write("Enter book ID: ");
            string id = Console.ReadLine();
            foreach(Book b in Lb){
                if (id == b.Id)
                    return b;
            }
            return null;
        }
        public void update(Book b)
        {
            Console.Write("New Name: ");
            string name = Console.ReadLine();
            Console.Write("New Publisher: ");
            string publisher = Console.ReadLine();
            Console.Write("New Price: ");
            string price = Console.ReadLine();
            b.Name = name;
            b.Publisher = publisher;
            b.Price = price;
            
        }
        public void delete(Book b)
        {
            Lb.Remove(b);
        }
        public void list()
        {
            foreach(Book b in Lb)
                Console.WriteLine(b.ToString());
        }
        public bool checkID(string id)
        {
            foreach(Book b in Lb)
            {
                if (id == b.Id) return false;
            }
            return true;
        }
    }
}
