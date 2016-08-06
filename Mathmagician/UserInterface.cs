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
        public int userNumbersToPrint { get; set; } = 0;
        public object returnedList { get; set; }

        // Query the user and set the user's command
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
                    Console.WriteLine($"...Called {userMathOperationCommand}...");
                    break;
                default:
                    break;
            }
        }

        public void PrintReturnedOperationList(List<int> returnedListOfIntegersFromOperation)
        {
            Console.WriteLine($"Your values are: ");
            foreach (var listItem in returnedListOfIntegersFromOperation)
            {
                Console.Write($"{listItem} ");
            }
            Console.Write("\n");
        }

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
