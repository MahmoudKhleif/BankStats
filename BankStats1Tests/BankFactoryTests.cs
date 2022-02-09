using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankStats1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStats1.Tests
{
    [TestClass()]
    public class BankFactoryTests
    {
        [TestMethod()]
        public void GetBankTest()
        {
            var BankTest = new BankFactory();
            var actual = BankTest.GetBank("45373");
            Assert.AreEqual(null, actual);
        }
    }
}