using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryNuget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNuget.Tests
{
    [TestClass()]
    public class BankFactoryTests
    {
        [TestMethod()]
        public void GetBankTest()
        {   // this test will return null if user insert Wrong number
            var BankTest = new BankFactory();
            var actual = BankTest.GetBank("45373");
            Assert.AreEqual(null, actual);
        }
    }
}