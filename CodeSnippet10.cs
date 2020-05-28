using System;

namespace CodeSnipet10
{
     class CodeSnippet10
    {
        public int Quantity;
        public int Cost;
    }
    class Goods
    {
        static void Main(string[] args)
        {
            CodeSnippet10 objCode = new CodeSnippet10();
            objCode.Quantity = 50;
            objCode.Cost = 75;
            Console.WriteLine("Quantity of the Product: " +objCode.Quantity);
            Console.WriteLine("Cost of the Product: " +objCode.Cost);
        }
    }
    class Pen : CodeSnippet10
    {

    }
}
