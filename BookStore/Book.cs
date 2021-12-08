using System;
namespace BookStore
{
    public class Book
    {
        public string name;
        public int cost;

        public Book(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
