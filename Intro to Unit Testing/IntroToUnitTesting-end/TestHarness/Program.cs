using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTesting101;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            Program harness = new Program();
            harness.RunTests();
        }

        private void RunTests()
        {
            WageComputer comp = new WageComputer();
            float retVal = comp.ComputeWages(40, 5, true);
            if (retVal == 200)
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
            Console.ReadKey();
        }
    }
}
