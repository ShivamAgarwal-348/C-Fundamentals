using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08
{
    internal struct WorkTask
    {
        public int Id;
        public string Name;

        public void Work()
        {
            Console.WriteLine($"{Id} {Name}");
        }
    }
}
