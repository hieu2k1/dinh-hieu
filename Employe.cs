﻿using System;

namespace Lab05


{
    public class Employe
    {
        private static int employeeCount = 1;
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeID;



        public string Name
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public double BaseSalary
        {
            get { return employeeBaseSalary; }
            set { employeeBaseSalary = value; }
        }

        public int ID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public Employe(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public string getName()
        {
            return this.Name;
        }

        public int getEmployeeID()
        {
            return this.ID;
        }

        public string toString()
        {
            return this.ID + "" + this.Name;
        }
        public virtual string employeeStatus()
        {
            return toString() + "is in the company's system";
        }
    }
}
