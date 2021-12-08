using System;

namespace BookStore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book("C++", 20000);
            Book book2 = new Book("Java", 25000);
            Book book3 = new Book("Kotlin", 25000);

            Bookshop shop = new Bookshop("Kitoblar olami", 1000000);

            Console.WriteLine(shop.HasBook()); //false
            Console.WriteLine(shop.HasBook(book1)); //false
            Console.WriteLine(shop.SellBook(book1)); //0
            Console.WriteLine(shop.BuyBooks(book1, 40)); // 40
            Console.WriteLine(shop.GetMoney()); //200000
            Console.WriteLine(shop.BuyBooks(book2, 20)); //8
            Console.WriteLine(shop.HasBook()); //true
            Console.WriteLine(shop.HasBook(book1)); //true
            Console.WriteLine(shop.SellBook(book1, 1)); //1
            Console.WriteLine(shop.SellBook(book3, 1)); //0
            Console.WriteLine(shop.GetMoney()); // 20000
            Console.WriteLine(shop.GetCount(book1)); //39
            Console.WriteLine(shop.GetCount()); //47
            Console.WriteLine(shop.GetShopName());
            Console.WriteLine(shop.GetCount(book2)); //8
        }
    }
}
