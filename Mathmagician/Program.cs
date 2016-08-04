using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();

            // Gets the user command and checks to see if its a valid command
            userInterface.InitialUserOperationCommand();
            userInterface.GetUserNumbersToPrint();
            userInterface.InitiateNumberOperation();
        }
    }
}
