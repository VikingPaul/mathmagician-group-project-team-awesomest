using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class UserInterface
    {
        public List<int> returnedOperationResult { get; set; } = null; // Holds the operation values returned from a called method
        
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
            }
            else if (result < 1)
            {
                Console.WriteLine("Whoops!");
                return true;
            }
            return false;
        }

        // Calls the correct operation method based on the users prior input
        public void InitiateNumberOperation(string userMathOperationCommand, int userNumbersToPrint)
        {
            switch (userMathOperationCommand)
            {
                case "integers":
                    Console.WriteLine($"...Called {userMathOperationCommand}..."); //Placeholder for compile and tests
                    returnedOperationResult = new List<int> { 1, 2, 3 }; //Placeholder for compile
                    break;
                case "primes":
                    Console.WriteLine($"...Called {userMathOperationCommand}..."); //Placeholder for compile and tests
                    returnedOperationResult = new List<int> { 1, 2, 3 }; //Placeholder for compile
                    break;
                case "fibonacci":
                    Console.WriteLine($"...Called {userMathOperationCommand}..."); //Placeholder for compile and tests
                    returnedOperationResult = new List<int> { 1, 2, 3 }; //Placeholder for compile
                    break;
                case "even":
                    Console.WriteLine($"...Called {userMathOperationCommand}..."); //Placeholder for compile and tests
                    returnedOperationResult = new List<int> { 1, 2, 3 }; //Placeholder for compile
                    break;
                case "odd":
                    Console.WriteLine($"...Called {userMathOperationCommand}..."); //Placeholder for compile and tests
                    returnedOperationResult = new List<int> { 1, 2, 3 }; //Placeholder for compile
                    break;
                default:
                    returnedOperationResult = new List<int> { 96500 }; 
                    break;
            }
        }

        // Adds the user's number values to a string for outputting to the Console
        public string ReturnedOperationValues()
        {
            string operationValues = "";
            foreach (var listItem in returnedOperationResult)
            {
                operationValues += $"{listItem} ";
            }
            return operationValues;
        }
    }
}
