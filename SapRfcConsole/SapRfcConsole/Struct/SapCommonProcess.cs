using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapRfcConsole.Struct
{
    public class SapCommonProcess
    {
        public IRfcFunction IRfcUnitTranfer { get; private set; }
        public RfcDestination dest { get; private set; }
        public RfcRepository repo { get; private set; }
        public SapCommonProcess(string strCreateFunction)
        {
            SapLogin.SapConnect(out RfcDestination dest, out RfcRepository repo);
            IRfcUnitTranfer = repo.CreateFunction(strCreateFunction);
            this.dest = dest;
            this.repo = repo;
        }
        public IRfcTable GetTable(string strTableName)
        {
            return IRfcUnitTranfer.GetTable(strTableName);
        }
        public void SetValue(string strFirst, string strSec)
        {
            IRfcUnitTranfer.SetValue(strFirst, strSec);
        }
        public string GetValue(string strValue)
        {
            string OUTPUT = IRfcUnitTranfer.GetValue(strValue).ToString();
            return OUTPUT;
        }
        public string GetString(string strGetString)
        {
            string Result = IRfcUnitTranfer.GetString(strGetString);
            return Result;
        }
        public void Invoke()
        {
            IRfcUnitTranfer.Invoke(dest);
        }
    }
}
