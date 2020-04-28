using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 2.Print Company Information
            //A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.
            //Write a program that reads the information about a company and its manager and prints it back on the console.
            Console.WriteLine("Company name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Company address:");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Phone number:");
            string phoneNum = Console.ReadLine();
            Console.WriteLine("Fax number:");
            string faxNum = Console.ReadLine();
            if (faxNum == string.Empty)
            {
                faxNum = "(no fax)";
            }
            Console.WriteLine("Web site:");
            string webSite = Console.ReadLine();
            Console.WriteLine("Manager first name:");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Manager last name:");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Manager age:");
            string managerAge = Console.ReadLine();
            Console.WriteLine("Manager phone:");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(companyName);
            Console.WriteLine($"Address: {companyAddress}");
            Console.WriteLine($"Tel. {phoneNum}");
            Console.WriteLine($"Fax: {faxNum}");
            Console.WriteLine($"Web site: {webSite}");
            Console.WriteLine($"Manager: {managerFirstName} {managerLastName} (age: {managerAge}, tel. {managerPhone})");
        }
    }
}
