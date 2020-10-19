using System;

namespace MyBookLibrary
{
    public class Book
    {
        private string id, name, publisher,price;

        public Book()
        {
        }

        public Book(string id, string name, string publisher, string price)
        {
            this.id = id;
            this.name = name;
            this.publisher = publisher;
            this.price = price;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Price { get => price; set => price = value; }

        public override string ToString()
        {
            return $"Book[ ID={Id}; Name={Name}; Publisher={Publisher}; Price={Price}]";
        }
    }
}
