﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStats1
{
    public class BankA:IBank
    {
        public string Withdraw()
        {
            return "Your requset is handeling by BankA";
        }
    }
}