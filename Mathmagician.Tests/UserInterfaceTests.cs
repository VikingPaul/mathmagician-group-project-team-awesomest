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
            //assert
            Assert.IsNotNull(new UserInterface());
        }

        //This tests to see if the List holding the returned values is properly intiallized as "null"
        [TestMethod]
        public void UserInterface_CheckTheAssignmentOfReturnedNumberList()
        {
            //arrange
            UserInterface myUserInterfaceList = new UserInterface();

            //assert
            Assert.IsNull(myUserInterfaceList.returnedOperationResult);
        }

        //This tests to see if the user interface can Set/Get the "returned" list of values and that a single element
        // matches what should be contained 
        [TestMethod]
        public void UserInterface_CanGetSetListOfNumbersAndReturnASingleElement()
        {
            //arrange
            UserInterface myUserInterfaceList = new UserInterface();
            myUserInterfaceList.returnedOperationResult = new List<int> { 7, 8, 9 };

            //assert
            Assert.AreEqual(8, myUserInterfaceList.returnedOperationResult[1]);
        }

        //Checks to see if the user command is not a valid command (it should return true, that the command is invalid)
        [TestMethod]
        public void UserInterface_TheUserCommandIsInvalid()
        {
            //arrange
            UserInterface myUserInterfaceCommand = new UserInterface();

            //assert
            Assert.IsTrue(myUserInterfaceCommand.CheckUserCommandInput("hello"));
        }

        //Checks to see if the user command (in lower case) is a valid command, (it should return False, in that the command is NOT invalid)
        [TestMethod]
        public void UserInterface_TheUserLowerCaseCommandIsValid()
        {
            //arrange
            UserInterface myUserInterfaceLowerCaseCommand = new UserInterface();

            //assert
            Assert.IsFalse(myUserInterfaceLowerCaseCommand.CheckUserCommandInput("fibonacci"));
        }

        //Checks to see if the user command (in mixed case) is a valid command, (it should return False, in that the command is NOT invalid)
        [TestMethod]
        public void UserInterface_TheUserMixedCaseCommandIsValid()
        {
            //arrange
            UserInterface myUserInterfaceMixedCaseCommand = new UserInterface();

            //assert
            Assert.IsFalse(myUserInterfaceMixedCaseCommand.CheckUserCommandInput("fiBoNAcci".ToLower()));
        }

        //Checks to see if the user "number of values" is a valid number, (it should return True, in that the command is invalid)
        [TestMethod]
        public void UserInterface_TheUserNumberOfValuesIsValid()
        {
            //arrange
            UserInterface myUserInterface = new UserInterface();

            //assert
            Assert.IsTrue(myUserInterface.CheckUserNumberInput("ten"));
        }

        //Checks to see if the user "number of values" is a valid number, (it should return False, in that the command is NOT invalid)
        [TestMethod]
        public void UserInterface_TheUserNumberOfValuesIsInvalid()
        {
            //arrange
            UserInterface myUserInterface = new UserInterface();

            //assert
            Assert.IsFalse(myUserInterface.CheckUserNumberInput("10"));
        }

        //The InitiateNumberOperation calls the individual operation method and assigns the returned results to the List returnedOperationResult.
        // The default of the switch statement should never be called but assigns a single element to returnedOperationResult = 96500
        [TestMethod]
        public void UserInterface_CheckTheExcecutionOfTheInitiateNumberOperation()
        {
            //arrange
            UserInterface myUserInterface = new UserInterface();

            //act
            myUserInterface.InitiateNumberOperation("", 0);

            //assert
            Assert.AreEqual(new List<int> { 96500 }[0], myUserInterface.returnedOperationResult[0]);
        }

        //Sets the returnedOperationResult List to {2, 66, 78 } and then calls the ReturnedOperationValues method which put the list values in a string
        // This checks to see if the returned thing is the correct string
        [TestMethod]
        public void UserInterface_IsTheResultsStringInFactTheCorrectString()
        {
            //arrange
            UserInterface myUserInterface = new UserInterface();
            myUserInterface.returnedOperationResult = new List<int> { 2, 66, 78 };

            //assert
            Assert.AreEqual("2 66 78 ", myUserInterface.ReturnedOperationValues());
        }
    }
}
