using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
  
        class Progra
        {
            static void Main(string[] args)
            {
                var employee1 = new Employe("Libby", 2000);
                var employee2 = new TechnicalEmploye("Zaynah");
                var employee3 = new BusinessEmploye("Winter");

                Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
            }
        }
    
}
