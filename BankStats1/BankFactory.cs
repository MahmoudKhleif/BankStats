using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStats1
{
    public class BankFactory:IBankFactory
    {
        public IBank GetBank(string bankCode)
        {
            switch (bankCode)
            {
                case "111111": return new BankA();
                case "222222": return new BankB();
                case "333333": return new BankC();
                case "444444": return new BankD();
                case "555555": return new BankE();

            }
            return null;
        }
    }
}
