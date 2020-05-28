using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1
{
    class TechnicalEmployee : Employee
    {
        public int successfullCheckIns = 5;

        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }

        public override string employeeStatus()
        {
            return this.toString() + "has" + this.successfullCheckIns + "successfull check ins";
        }
    }
}
