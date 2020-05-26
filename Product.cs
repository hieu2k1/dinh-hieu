using System;

namespace Code_Snippet_6
{
    static class Product
    {
        static int productId;
        static double price;
        static Product()
        {
            productId = 10;
            price = 156.32;
        }
        public static void Display()
        {
            Console.WriteLine("Product ID: " + productId);
            Console.WriteLine("Product price: " + price);
        }
    }

    class Medicine
    {
        static void Main(string[] args)
        {
            Product.Display();
        }
    }
}

