using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem!");
            Console.WriteLine("Valid User Last Name!");
            string name = "^[A-Za-z]{3,}[ ][A-Za-z]{3,}$";

            Regex regex = new Regex(name);
            Console.WriteLine("Enter first and last name:");
            string s = Console.ReadLine();
            Console.WriteLine("It is: " + regex.IsMatch(s));
        }
    }
}