using System;

namespace CodeSnippet6
{
    class CodeSnippet6
    {
        public CodeSnippet6()
        {
            Console.WriteLine("Animal constructor without parameters");

        }
        public CodeSnippet6(String name)
        {
            Console.WriteLine("Animal constructor with a string parameter");
        }
    }
    class Canine : CodeSnippet6
    {
        public Canine() : base("Lion")
        {
            Console.WriteLine("Derived Canine");
        }
    }
    class Details
    {
        static void Main(string[] args)
        {
            Canine objCanine = new Canine();
        }
    }
}
