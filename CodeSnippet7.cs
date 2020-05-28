using System;

namespace CodeSnippet7
{
    class CodeSnippet7
    {
        string metalType;
        public CodeSnippet7(string type)
        {
            metalType = type;
            Console.WriteLine("Metal:\t\t" + metalType);
        }
       
    }
    class SteelCompany : CodeSnippet7
    {
        string _grade;
        public SteelCompany(string grade) : base("Steel")
        {
            _grade = grade;
            Console.WriteLine("Grade: \t\t" + grade);
        }
    }
    class Automobiles : SteelCompany
    {
        string _part;
        public Automobiles(string part) : base("Cast Iron")
        {
            _part = part;
            Console.WriteLine("Part: \t\t" +_part);
        }
        static void Main(string[] args)
        {
            Automobiles objAutomobiles = new Automobiles("Chassies");
        }
    }
}
