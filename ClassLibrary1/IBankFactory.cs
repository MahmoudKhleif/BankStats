﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNuget

{
    public interface IBankFactory
    {
        IBank GetBank(string bankCode);
    }
}
