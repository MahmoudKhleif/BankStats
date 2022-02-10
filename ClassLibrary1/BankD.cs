using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNuget
{
    public class BankD:IBank
    {
        public string Withdraw()
        {
            return "Your requset is handeling by BankD";
        }
    }
}
