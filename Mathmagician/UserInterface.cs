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
                return true;
            }
            else if (result < 1)
            {
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
                    returnedOperationResult = new List<int>(new Integer().PrintInteger(userNumbersToPrint)); 
                    break;
                case "primes":
                    returnedOperationResult = new Prime(userNumbersToPrint).PrimeList(); 
                    break;
                case "fibonacci":
                    returnedOperationResult = new List<int>(new Fibonacci().PrintFib(userNumbersToPrint));
                    break;
                case "even":
                    returnedOperationResult = new Even(userNumbersToPrint).EvenList();
                    break;
                case "odd":
                    returnedOperationResult = new Odd().CountOddNumbers(userNumbersToPrint);
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
