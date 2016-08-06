using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class UserInterface
    {
        // Calls the correct operation method based on the users prior input
        public void InitiateNumberOperation(string userMathOperationCommand, int userNumbersToPrint)
        {
            switch (userMathOperationCommand)
            {
                case "integers":
                    Console.WriteLine($"...Called {userMathOperationCommand}...");
                    break;
                case "primes":
                    Console.WriteLine($"...Called {userMathOperationCommand}...");
                    break;
                case "fibonacci":
                    Console.WriteLine($"...Called {userMathOperationCommand}...");
                    break;
                case "even":
                    Console.WriteLine($"...Called {userMathOperationCommand}...");
                    break;
                case "odd":
                    Console.WriteLine($"...Called {userMathOperationCommand}...");
                    // Odd oddNumbers = new Odd();
                    //  returnedOperationResult = oddNumbers.CountOddNumbers(userNumbersToPrint);
                    break;
                default:
                    break;
            }
        }

        // Prints the user's results
        List<int> returnedOperationResult { get; set; } // Holds the operation values returned from a called method
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
        public bool CheckUserCommandInput(string sentUserMathOperationCommand)
        {
            if (sentUserMathOperationCommand != "integers"
                && sentUserMathOperationCommand != "primes"
                && sentUserMathOperationCommand != "fibonacci"
                && sentUserMathOperationCommand != "even"
                && sentUserMathOperationCommand != "odd")
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
            return false;
        }
    }
}
