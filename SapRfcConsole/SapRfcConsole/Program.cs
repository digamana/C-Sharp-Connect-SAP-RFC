using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapRfcConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var test = new RFC.ZTEST_SAIRPORT();
            var lst = test.lst_IT_HEAD;
        }
 
    }
}
