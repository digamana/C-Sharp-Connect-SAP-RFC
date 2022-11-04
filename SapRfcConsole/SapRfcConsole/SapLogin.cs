using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapRfcConsole
{
    public static class SapLogin
    {
        public static void SapConnect(out RfcDestination dest, out RfcRepository repo)
        {

            RfcConfigParameters argsP = new RfcConfigParameters();
            argsP.Add(RfcConfigParameters.Name, "DS4");
            argsP.Add(RfcConfigParameters.AppServerHost, "Your_Sap_IP");
            argsP.Add(RfcConfigParameters.SystemNumber, "00");
            argsP.Add(RfcConfigParameters.SystemID, "DS4");
            argsP.Add(RfcConfigParameters.User, "User_Account");
            argsP.Add(RfcConfigParameters.Password, "User_Password");
            argsP.Add(RfcConfigParameters.Client, "100");
            argsP.Add(RfcConfigParameters.Language, "ZF");


             dest = RfcDestinationManager.GetDestination(argsP);
             repo = dest.Repository;
        }
    }
}
