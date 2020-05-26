using System;

namespace Code_Snippet_17
{
    class Code_Snippet_17
    {
        string empName;
        int empAge;
        string deptName;
        Code_Snippet_17(string name, int num)
        {
            empName = name;
            empAge = num;
            deptName = "Research & Development";
        }
        static void Main(string[] args)
        {
            Code_Snippet_17 objCS17 = new Code_Snippet_17("John", 10);
            Console.WriteLine(objCS17.deptName);
        }
    }
}
