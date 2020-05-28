using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    class BusinessEmploye : Employee
    {
        public double bonusBudget = 1000;
        public BusinessEmploye(String name) : base(name, 50000)
        {

        }
        public override string employeeStatus()
        {
            return toString() + "with a budget of" + this.bonusBudget;
        }
    }
}
