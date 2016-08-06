using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class UserInterface
    {
        // Holds the User's Operation Command
        public string userMathOperationCommand { get; set; } = null;
        
        // Holds the User's Numbers to Print
        public int userNumbersToPrint { get; set; } = 0;
        
        // Holds the operation values returned from a called method
        public List<int> returnedOperationResult { get; set; }

        // Query the user and set the user's operation command
        public void InitialUserOperationCommand()
        {
            bool wrongInput = true;
            while (wrongInput)
            {
                Console.Write("What would you like for me to do? ");
                userMathOperationCommand = Console.ReadLine();
                wrongInput = CheckUserCommandInput();
            }
        }

        // Query the user for the number of operation results to print and set it 
        public void GetUserNumbersToPrint()
        {
            bool wrongInput = true;
            string userStringNumberToPrint = null;

            while (wrongInput)
            {
                Console.Write("How many should I print? ");
                userStringNumberToPrint = Console.ReadLine();
                wrongInput = CheckUserNumberInput(userStringNumberToPrint);
            }
        }

        // Calls the correct operation method based on the users prior input
        public void InitiateNumberOperation()
        {
            Console.WriteLine($"\nCool, I'm going to print {userNumbersToPrint} {userMathOperationCommand} numbers.");

            switch (userMathOperationCommand)
            {
                case "Integers":
                    Console.WriteLine($"...Called {userMathOperationCommand}...");
                    break;
                case "Primes":
                    Console.WriteLine($"...Called {userMathOperationCommand}...");
                    break;
                case "Fibonacci":
                    Console.WriteLine($"...Called {userMathOperationCommand}...");
                    break;
                case "even":
                    Console.WriteLine($"...Called {userMathOperationCommand}...");
                    break;
                case "odd":
                    Odd oddNumbers = new Odd();
                    returnedOperationResult = oddNumbers.CountOddNumbers(userNumbersToPrint);
                    break;
                default:
                    break;
            }
        }

        // Prints the user's results
        public void PrintReturnedOperationList()
        {
            Console.Write($"Your values are: ");
            foreach (var listItem in returnedOperationResult)
            {
                Console.Write($"{listItem} ");
            }
            Console.Write("\n");
        }

        // Checks to see if the users operation command is one of the five operations
        public bool CheckUserCommandInput()
        {
            if (userMathOperationCommand != "Integers"
                && userMathOperationCommand != "Primes"
                && userMathOperationCommand != "Fibonacci"
                && userMathOperationCommand != "even"
                && userMathOperationCommand != "odd")
            {
                Console.WriteLine("Whoops!");
                return true;
            }
                return false;
        }

        // Checks to see if the user-entered "number" of results to display is actually an integer 
            public bool CheckUserNumberInput(string sentUserStringNumberToPrint)
        {
            int result;

            if (!Int32.TryParse(sentUserStringNumberToPrint, out result))
            {
                Console.WriteLine("Whoops!");
                return true;
            } else if (result < 1)
            {
                Console.WriteLine("Whoops!");
                return true;
            }
            userNumbersToPrint = result;
            return false;
        }
    }
}
