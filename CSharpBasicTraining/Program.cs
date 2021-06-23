using System;

namespace CSharpBasicTraining
{
    class Program
    {
        public static void Main(string[] args)
        {
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
