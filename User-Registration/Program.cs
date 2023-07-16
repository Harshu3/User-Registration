using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem!");
            Console.WriteLine("Valid User Email ID!");
            string name = @"[a-z]{3,}.?[a-z0-9]{3,}[@][a-z]{2,}.(com|org)$";

            Regex regex = new Regex(name);
            Console.WriteLine("Enter Email ID:");
            string s = Console.ReadLine();
            Console.WriteLine("It is: " + regex.IsMatch(s));
        }
    }
}