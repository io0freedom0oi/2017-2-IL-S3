using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ITI.AccountManagement.Tests
{
    [TestFixture]
    public class AccountTests
    {
        [Test]
        public void can_get_balance()
        {
            Account account = new Account("12336547865", "1234", 3000);

            int balance = account.GetBalance("1234");

            Assert.AreEqual(3000, balance);
        }

        [Test]
        public void can_change_password()
        {
            Account account = new Account("7458965441", "0185", 8000);
            account.ChangePassword("0185", "9876");
            Assert.AreEqual(8000, account.GetBalance("9876"));
        }
    }
}
