﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01
{
    class AnonType
    {
        static void Main(string[] args)
        {
            var p1 = new { Name = "A", Price = 3 };
            Console.WriteLine("Name = {0}\nPrice = {1}", p1.Name.ToLower(), p1.Price);
            Console.ReadLine();
        }
    }
}
