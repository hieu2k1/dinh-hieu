using System;

namespace BaithiBaithi

{
    class test
    {
        static void Main(string[] args)
        {
            MobilePhone m1 = new MobilePhone(13);
            Console.WriteLine("tien thue cua san pham la:" + m1.computeTax());

            book book = new book(12);
            Console.WriteLine("tien thue cua sach la:" + book.computeTax());
            Console.ReadKey();
        }
    }
}