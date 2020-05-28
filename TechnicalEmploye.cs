using System;

namespace Lab05

{
    class TechnicalEmploye : Employe
    {
        public int successfullCheckIns = 5;

        public TechnicalEmploye(String name) : base(name, 7000)
        {

        }
        public override String employeeStatus()
        {
            return this.toString() + "has" + this.successfullCheckIns + "successfull check ins";
        }
    }
}