using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class UserInterfaceTests
    {
        //Checks to see if an instance of UserInterface can be created 
        [TestMethod]
        public void UserInterface_EnsureICanCreateAnInstance()
        {
            //arrange (nothing in this case)

            //act (nothing in this case)

            //assert
            Assert.IsNotNull(new UserInterface());
        }

        //This tests to see if the user Operation String can Set/Get 
        [TestMethod]
        public void UserInterface_CanGetSetUserMathOperationCommand()
        {
            //arrange
            UserInterface myUserInterfaceCommand = new UserInterface();

            //act
            myUserInterfaceCommand.userMathOperationCommand = "hello";

            //assert
            Assert.AreEqual("hello", myUserInterfaceCommand.userMathOperationCommand);
        }

        //Checks to see if the user command is not a valid command (it should return true, that the command is invalid)
        [TestMethod]
        public void UserInterface_TheUserCommandIsInvalid()
        {
            //arrange
            UserInterface myUserInterfaceMixedCaseCommand = new UserInterface();

            //act
            myUserInterfaceMixedCaseCommand.userMathOperationCommand = "FiBoNaCci";

            //assert
            Assert.IsTrue(myUserInterfaceMixedCaseCommand.CheckUserCommandInput());
        }

        //Checks to see if the user command is a valid command, it looks at lower case (it should return False, in that the
        // command is not invalid)
        [TestMethod]
        public void UserInterface_TheUserCommandIsValid()
        {
            //arrange
            UserInterface myUserInterfaceLowerCaseCommand = new UserInterface();

            //act
            myUserInterfaceLowerCaseCommand.userMathOperationCommand = "fibonacci";

            //assert
            Assert.IsFalse(myUserInterfaceLowerCaseCommand.CheckUserCommandInput());
        }

        //This tests to see if the user Operation String can Set/Get 
        [TestMethod]
        public void UserInterface_CanGetSetUserNumbersToPrintCommand()
        {
            //arrange
            UserInterface myUserInterfacePrintNumber = new UserInterface();

            //act
            myUserInterfacePrintNumber.userNumbersToPrint = 7;

            //assert
            Assert.AreEqual(7, myUserInterfacePrintNumber.userNumbersToPrint);
        }

        //This tests to see if the user interface can Set/Get the "returned" list and that a single element
        // matches what should be contained 
        [TestMethod]
        public void UserInterface_CanGetSetListOfNumbersAndReturnASingleElement()
        {
            //arrange
            UserInterface myUserInterfaceList = new UserInterface();

            //act
            myUserInterfaceList.returnedOperationResult = new List<int> { 7, 8, 9 };

            //assert
            Assert.AreEqual(8, myUserInterfaceList.returnedOperationResult[1]);
        }
    }
}
