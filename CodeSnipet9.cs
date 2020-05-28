using System;

namespace CodeSnippet9
{
    class CodeSnipet9
    {
        string studentName = "Hieu";
        string address = "Nam Dinh";
        public virtual void PrintDetails()
        {
            Console.WriteLine("student Name: " +studentName);
            Console.WriteLine("address: " +address);
        }
    }
    class Grade : CodeSnipet9
    {
        string  _class = "Four";
        float  _percent = 71.25F;
        public override void PrintDetails()
        {
            Console.WriteLine("Class: " +  _class);
            Console.WriteLine("Percentage: " +  _percent);
        }
        static void Main(string[] args)
        {
            CodeSnipet9 objCode = new CodeSnipet9();
            Grade objGrade = new Grade();
            objCode.PrintDetails();
            objGrade.PrintDetails();
        }
    }
}
