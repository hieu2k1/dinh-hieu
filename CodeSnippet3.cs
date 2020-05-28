
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CodeSnippet3
{
    class CodeSnippet3
    {
        protected string Food;
        protected string Activity;
    }
    class Cat: CodeSnippet3
    {
        static void Main(string[]args)
        {
            Cat objCat = new Cat();
            objCat.Food = "Mouse";
            objCat.Activity = "laze around";
            Console.WriteLine("the cat loves to eat" + objCat.Food + ".");
            Console.WriteLine("the cat loves to" + objCat.Activity + ".");
        }
    }
}
