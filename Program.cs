using System;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string sFullName;
            string sGreeting;

            Console.Write("Please enter your full name: ");
            sFullName = Console.ReadLine();

            switch (sFullName)
            {
                case "Bill Gates":
                    sGreeting = "Great job in C#";
                    break;
                case "Cathy Folkard":
                    sGreeting = "That Cathy is really cool";
                    break;
                case "Alan Turing":
                    sGreeting = "The Turing machine was amazing";
                    break;

                default:
                    sGreeting = "We're waiting for your contribution to computer science, " + sFullName;
                    break;
            }


            Console.WriteLine(sGreeting);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
