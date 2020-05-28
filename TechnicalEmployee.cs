using System;

namespace Lab05

{
    class TechnicalEmployee : Employee
    {
        public int successfullCheckIns = 5;

        public TechnicalEmployee(String name) : base(name, 7000)
        {

        }
        public override String employeeStatus()
        {
            return this.toString() + "has" + this.successfullCheckIns + "successfull check ins";
        }
    }
}