using System;

namespace CodeSnippet5
{
    class CodeSnippet5
    {
        int empId = 1;
        string empName = "vudinhhieu";
        int age = 19;
        public void Display()
        {
            Console.WriteLine("employeeID:" + empId);
            Console.WriteLine("employeeName:" + empName);
        }
    }
    class Department : CodeSnippet5
    {
        int deptId = 501;
        string deptName = "Sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine("Department ID:" + deptId);
            Console.WriteLine("Department Name:" + deptName);
        }
        static void Main(string[] args)
        {
            Department objDepartment = new Department();
            objDepartment.Display();
        }
    }
}
