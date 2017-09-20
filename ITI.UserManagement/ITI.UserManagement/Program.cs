using System;

namespace ITI.UserManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            User john = new User();
            john.UserName = "John";
            john.SetPassword("password");
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            if(john.PasswordMatch(password))
            {
                Console.WriteLine("Success !");
            }
            else
            {
                Console.WriteLine("Failure...");
            }
            Console.ReadLine();
        }
    }
}
