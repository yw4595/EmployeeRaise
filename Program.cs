using System;

namespace ConsoleApp1
{
    // Author: [Your Name]
    // Purpose: Console application to give a salary raise to a user if their name matches a given name
    // Restrictions: None
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable of type employee struct
            employee emp;

            // Prompt user to enter their name
            Console.WriteLine("Enter your name:");

            // Read user's name from the console
            emp.sName = Console.ReadLine();

            // Set the initial salary to $30,000
            emp.dSalary = 30000;

            // Call the GiveRaise function passing the employee struct as a parameter by reference
            bool gotRaise = GiveRaise(ref emp);

            // Check if the employee got a raise
            if (gotRaise)
            {
                Console.WriteLine("Congratulations {0}! You got a raise. Your new salary is ${1:N}.", emp.sName, emp.dSalary);
            }
            else
            {
                Console.WriteLine("Sorry {0}, you didn't get a raise. Your salary is still ${1:N}.", emp.sName, emp.dSalary);
            }
        }

        // Purpose: Give a salary raise to an employee if their name matches a given name
        // Restrictions: None
        // Parameters:
        //      emp: Employee struct
        // Returns: True if the employee got a raise, false otherwise
        static bool GiveRaise(ref employee emp)
        {
            // Check if the employee's name matches the given name
            if (emp.sName.ToLower() == "yanzhi wang")
            {
                // Give a raise of $19,999.99 if the employee's name matches the given name
                emp.dSalary += 19999.99;

                // Return true to indicate that the employee got a raise
                return true;
            }

            // Return false to indicate that the employee didn't get a raise
            return false;
        }
    }

    // Define an employee struct with two fields: name and salary
    struct employee
    {
        public string sName;
        public double dSalary;
    }
}
