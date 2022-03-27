using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccounts;

namespace BankTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //zaduzenje s vazecim iznosom
        public void Debit_WithValidAmount()
        {
            double beginnigBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            BankAccount account = new BankAccount("Joe Doe", beginnigBalance);

            account.Debit(debitAmount);

            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        
        }


    }
}