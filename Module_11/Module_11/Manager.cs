using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    internal class Manager : Employee
    {
        public Manager(string name = "abc") : base(name)
        {

        }
        public override void PerformWork()
        {
            base.PerformWork();
        }
    }
}
