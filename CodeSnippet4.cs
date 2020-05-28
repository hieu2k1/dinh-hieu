using System;

namespace CodeSnippet4

{
    class CodeSnippet4
    {
        public void Eat()
        {

        }
        class Dog : CodeSnippet4
        {
            public void Eat() { }
            static void Main(string[] args)
            {
                Dog objDog = new Dog();
                objDog.Eat();
                base.Eat();
            }
        }

    }
}
