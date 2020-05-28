using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1
{
    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;

        public BusinessEmployee(string name) : base(name, 50000)
        {

        }
        public override string employeeStatus()
        {
            return toString() + "with a budget of" + this.bonusBudget;
        }
    }
}
