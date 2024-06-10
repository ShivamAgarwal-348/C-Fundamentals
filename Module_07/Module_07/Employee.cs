using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        public Employee(string first, string last, string mail, DateTime bd) : this(first, last, mail, bd, 0)
        {
        }
        public Employee(string first, string last, string mail, DateTime bd, double rate)
        {
            this.firstName = first;
            this.lastName = last;
            this.email = mail;
            this.birthDay = bd;
            this.hourlyRate = rate;
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
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hours! and recieved a wage of {wage}");
            if (reset)
            {
                numberOfHoursWorked = 0;
            }
            return wage;
        }
    }
}
