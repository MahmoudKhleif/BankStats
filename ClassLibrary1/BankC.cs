﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNuget
{
   public class BankC:IBank
    {
        public string Withdraw()
        {
            return "Your requset is handeling by BankC";
        }
    }
}
