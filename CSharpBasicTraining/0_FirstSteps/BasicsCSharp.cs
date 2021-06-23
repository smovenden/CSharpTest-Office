using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicTraining._0_FirstSteps
{
    public class BasicsCSharp
    {
        public static void BasicsCSharpRun()
        {
            //Variable declaration
            string message;

            //Variable assignment
            message = "have a nice day!";

            //Outut ariable
            Console.WriteLine("Hi Retail Express - " + message);

            //output to screen
            Console.WriteLine("World end in..." + Sum(10, 12));
        }

        public static int Sum(int var1, int var2)
        {
            //calculation sum returned from call
            return var1 + var2;
        }
    }
}
