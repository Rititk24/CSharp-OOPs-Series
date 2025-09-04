using System;

namespace abstratction
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double Salary;
        double tax = 0.1;

        public Employee(int id, string name, double salary)
        {
            this.EmpId = id;
            this.EmpName = name;
            this.Salary = salary;
        }

        void calculateSalary()
        {
            if (Salary >= 15000)
            {
                double netSalary = Salary - (tax * Salary);
                Console.WriteLine("Your Salary is" + netSalary);
            }
            else
            {
                Console.WriteLine("Your Salary is {0}+ " + Salary);
            }
        }
        public void ActualSalary()
        {
            this.calculateSalary();
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Employee EmpDetails = new Employee(3316, "Ritik", 21000);
            EmpDetails.ActualSalary();
            Console.ReadLine();
        }
    }
}