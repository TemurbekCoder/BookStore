using System;
using System.Collections.Generic;

namespace BookStore
{
    public class Bookshop
    {
        private string _name;
        private int _money;
        private Dictionary<Book, int> _books; 

        public int GetMoney()
        {
            return _money;
        }

        public Bookshop(string name, int money)
        {
            this._name = name;
            this._money = money;

            this._books = new Dictionary<Book, int>();
        }

        public int BuyBooks(Book book, int count)
        {
            if (book.cost * count <= _money)
            {
                _money -= book.cost * count;
                AddBook(book, count);

                return count;
            }

            int counter = _money / book.cost;

            _money -= counter * book.cost;
            AddBook(book, counter);

            return counter;
        }

        //**//
        public void AddBook(Book book, int count)
        {
            if (_books.ContainsKey(book))
                _books[book] += count;
            else
                _books.Add(book, count);
        }
        //**//

        public bool HasBook()
        {
            return _books.Count > 0;
        }

        public bool HasBook(Book book)
        {
            return _books.ContainsKey(book);
        }

        public int SellBook(Book book, int count = 1)
        {
            if (!_books.ContainsKey(book))
                return 0;

            int countBook = _books[book];

            if (countBook >= count)
            {
                _money += book.cost * count;
                _books[book] = countBook - count;
                return count;
            }

            _money += book.cost * countBook;
            _books[book] = 0;
            return countBook;
        }

        public int GetCount(Book book)
        {
            if(_books.ContainsKey(book))
                return _books[book];

            return 0;
        }

        public int GetCount()
        {
            int count = 0;

            foreach (var book in _books)
                count += book.Value;

            return count;
        }

        public string GetShopName()
        {
            return _name;
        }        

    }
}
