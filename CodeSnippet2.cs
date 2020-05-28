using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippet2
{
    class CodeSnippet2
    {
        public void Eat()
        {
            Console.WriteLine("every animal eats something .");

        }
        public void DoSomething()
        {
            Console.WriteLine("every animal does something.");
        }
    }
    class Cat : CodeSnippet2
    {
        static void Main(string [] args)
        {
            Cat objCat=new Cat();
            objCat.Eat();
            objCat.DoSomething();
        }
    }
}
