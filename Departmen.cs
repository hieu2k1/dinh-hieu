using System;
using System.Collections;

namespace Code10
{
    class Departmen : IEnumerable
    {
        string[] departmentNames = { "Marketing", "Finace", "Information Technology", "Human Resources" };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < departmentNames.Length; i++)
            {
                yield return departmentNames[i];
            }
        }
        static void Main(string[] args)
        {
            Departmen objDepartment = new Departmen();
            Console.WriteLine("Department Names");
            Console.WriteLine();
            foreach (string str in objDepartment)
            {
                Console.WriteLine(str);
            }
        }
        }
    }
