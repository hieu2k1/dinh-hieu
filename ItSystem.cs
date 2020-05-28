using System;

namespace CodeSnippet11
{
    class ItSystem
    {
        public virtual void Print()
        {
            Console.WriteLine("The system should be handled carefully");

        }
    }
    class CompanySystem : ItSystem
    {
        public override sealed void Print()
        {
            Console.WriteLine("The system information is confidential");
            Console.WriteLine("This information should not be overridden");
        }
    }
    class SealedSystem : CompanySystem
    {
        public void Print()
        {
            Console.WriteLine("This statement won’t get executed");
        }
        static void Main(string[] args)
        {
            SealedSystem objSealed = new SealedSystem();
            objSealed.Print();
        }
    }

}
