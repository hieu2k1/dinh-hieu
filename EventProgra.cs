using System;

namespace SampleApp
{
    public delegate string MyDel(string str);

    class EventProgra
    {
        event MyDel MyEvent;

        public EventProgra()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);

        }
        public string WelcomeUser(string username)
        {
            return "Welcome" + username;
        }
        static void Main(string [] args)
        {
            EventProgra obj1 = new EventProgra();
            string result = obj1.MyEvent("Tutorials Point");
            Console.WriteLine(result);
        }
          
    }
}
