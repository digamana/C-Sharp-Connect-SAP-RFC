﻿using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapRfcConsole.Struct.Interface
{
    public interface IStructBasic<T>
    {
        T GetT(IRfcStructure rfcStructure);
    }
}
