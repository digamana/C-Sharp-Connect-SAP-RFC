using SapRfcConsole.Struct;
using SapRfcConsole.Struct.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapRfcConsole.RFC
{
    class ZTEST_SAIRPORT : ISapLogin
    {
        public SapCommonProcess sapCommonProcess { get ; set ; }
        public List<IT_HEAD> lst_IT_HEAD { get; set; }
        public ZTEST_SAIRPORT()
        {
            sapCommonProcess = new SapCommonProcess("ZTEST_SAIRPORT");
            sapCommonProcess.Invoke();
            lst_IT_HEAD = new StructElement<IT_HEAD>(sapCommonProcess.GetTable("IT_HEAD")).ToList;
        }
    }
}
