using System;

namespace Code_Snippet_20
{
    class Code_Snippet_20
    {
        private int empId;
        private string empName;
        private int age;
        private double salary;

        Code_Snippet_20(int id, string name, int age, double sal)
        {
            Console.WriteLine("Constructor for Employee called");
            empId = id;
            empName = name;
            age = age;
            salary = sal;
        }
        Code_Snippet_20()
        {
            Console.WriteLine("Destructor for Employee called");
        }
        static void Main(string[] args)
        {
            Code_Snippet_20 objCS20 = new Code_Snippet_20(1, "John", 45, 35000);
            Console.WriteLine("Employee ID: " + objCS20.empId);
            Console.WriteLine("Employee Name: " + objCS20.empName);
            Console.WriteLine("Age: " + objCS20.age);
            Console.WriteLine("Salary: " + objCS20.salary);
        }
    }
}