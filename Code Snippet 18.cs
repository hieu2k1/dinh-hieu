using System;

namespace Code_Snippet_18
{
    class Code_Snippet_18
    {
        static int valueOne = 10;
        static int product;
        static Code_Snippet_18()
        {
            Console.WriteLine("Static Constructor initialized");
            product = valueOne * valueOne;
        }
        public static void Method()
        {
            Console.WriteLine("Value of product = " + product);
        }
        static void Main(string[] args)
        {
            Code_Snippet_18.Method();
        }
    }

}
