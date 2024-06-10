using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    public class Employee
    {
        protected string name;
        public Employee(string name = "abc") 
        {
            Name = name;
        }
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        public virtual void PerformWork()
        {
            Console.WriteLine("Work");
        }
    }
}
