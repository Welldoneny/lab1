using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bank_Library;

namespace UnitTestBankLibrary
{
    [TestClass]
    public class BankLibraryTests
    {
        [TestMethod]
        public void NameTest()
        {
            // arrange
            string expected = "example name";

            //act
            Bank_Account bank_Account = new Bank_Account("example", "name");
            string actual = bank_Account.Name();

            //assert
            Assert.AreEqual(expected, actual);            
        }

        [TestMethod]
        public void NameTestAnother()
        {
            //arrange
            string firstname = "John";
            string lastname = "Wick";
            string expected = "John Wick";

            //act
            Bank_Account bank_Account = new Bank_Account(firstname, lastname);
            string actual = bank_Account.Name();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMoneyTest()
        {
            //arrange 
            int moneytoadd = 3500;
            int expected = 3500;

            //act
            Bank_Account bank_Account = new Bank_Account("example", "name");
            bank_Account.Create_Check("example", moneytoadd);
            int actual = Convert.ToInt32(bank_Account.GetMoneyOnTheCheck(0));

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusMoneyTest()
        {
            //arrange
            int moneytominys = 1000;
            int expected = 1500;

            //act
            Bank_Account bank_Account = new Bank_Account("example", "name");
            bank_Account.Create_Check("example", 2500);
            bank_Account.Minys(0, moneytominys);
            int actual = Convert.ToInt32(bank_Account.GetMoneyOnTheCheck(0));

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShowStatusEmptyTest()
        {
            //arrange
            string expected = "You dont have any checks";

            //act
            Bank_Account bank_Account = new Bank_Account("example", "name");
            string actual = bank_Account.ShowChecks();

            //arrange
            Assert.AreEqual(expected, actual);
        }
    }
}
