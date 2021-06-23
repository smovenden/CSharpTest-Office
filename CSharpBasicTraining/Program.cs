using System;

namespace CSharpBasicTraining
{
    class Program
    {

        private const string Question1 = "Hello!  What is your name?";
        private const string Question2 = "How old are you?";
        private static string Answer1;
        private static string Answer2;

        public static void Main(string[] args)
        {
            Console.WriteLine(Question1);

            Answer1 = Console.ReadLine();

            Console.WriteLine(Question2);

            Answer2 = Console.ReadLine();

            int age = int.Parse(Answer2);

            switch (age)
            {
                case 0 - 7:
                    Console.WriteLine($"Hello {Answer1}, I am also {Answer2}!");
                    break;
                case 8 - 50:
                    Console.WriteLine("Hi " + Answer1 + ". " + age + " isn't too old!");
                    break;
                default:
                    Console.WriteLine("Hi " + Answer1 + ". " + age + "!  Is your birthstone lava!");
                    break;
            }


            // if (age > 40 && age < 70)
            //{
            //Console.WriteLine("Hi " + Answer1 + ". " + age + " is old!");
            //}
            //else
            //{
            //    Console.WriteLine($"Hello {Answer1}, I am also {Answer2}!");
            //}

        }
        
    }
}
