using System;

namespace Slicer
{
    internal static class Program
    {
        private static void Main()
        {
            //Get user email address
            Console.Write("What is your email address?: ");
            var email = Console.ReadLine();

            //Slice out user name
            var user = email.Substring(0, email.IndexOf("@"));

            //Slice out domain name
            var domain = email.Substring(email.IndexOf("@") + 1);

            //Format message
            var output = $"Your user name is {user} and your domain name is {domain}";

            //Print user namd and domain
            Console.WriteLine(output);
        }
    }
}
