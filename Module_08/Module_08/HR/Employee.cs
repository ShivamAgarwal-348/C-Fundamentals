using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08.HR
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        private double wage;
        public double hourlyRate;

        public DateTime birthDay;
        public static double taxRate = 0.15;

        public Employee(string first, string last, string mail, DateTime bd) : this(first, last, mail, bd, 0)
        {
        }
        public Employee(string first, string last, string mail, DateTime bd, double rate)
        {
            firstName = first;
            lastName = last;
            email = mail;
            birthDay = bd;
            hourlyRate = rate;
        }

        public void PerformWork()
        {
            numberOfHoursWorked++;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hours!");
        }
        public void PerformWork(int n)
        {
            numberOfHoursWorked += n;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hours!");
        }
        public double RecieveWage(bool reset = true)
        {
            wage = numberOfHoursWorked * hourlyRate * (1 - taxRate);
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hours! and recieved a wage of {wage}");
            if (reset)
            {
                numberOfHoursWorked = 0;
            }
            return wage;
        }
        public static void DisplayTaxRate()
        {
            Console.WriteLine(taxRate);
        }
        public double Wage
        {
            get { return wage; }
            private set { wage = value; }
        }
    }
}
