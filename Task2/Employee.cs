using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Employee:Person
    {
        public Employee(string name,string surname,byte age,double salaryOfHour,double workingHour)
        {
            this.Name = name;
            this.Surname = surname;
            if(age>=18)
            this.Age = age;
            this.SalaryOfHour = salaryOfHour;
            this.WorkingHour = workingHour;
        }

       
        private double _workingHour;

        public double SalaryOfHour { get; set; }
        public double WorkingHour { get=>_workingHour; set { if (value / 30 <= 8) _workingHour = value; } }
        public void CalculateSalary()
        {
            if(SalaryOfHour * WorkingHour>250)
            Console.WriteLine(SalaryOfHour * WorkingHour); 
        } 

    }
}
