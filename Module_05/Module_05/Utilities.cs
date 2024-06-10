using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    internal class Utilities
    {
        public static int AddTwoNumbers(int a, int b = 200)
        {
            return a + b;
        }
        public static int AddTwoNumbersExpressionBody(int a, int b = 200) => a + b;
        
        public static void DisplaySum(int a)
        {
            Console.WriteLine($"Sum : {a}");
        }
        public static void DisplaySum(int a, int b)
        {
            Console.WriteLine($"Sum : {a + b}");
        }

    }
}
