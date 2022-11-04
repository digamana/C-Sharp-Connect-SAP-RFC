using SAP.Middleware.Connector;
using SapRfcConsole.Struct.Interface;

namespace SapRfcConsole
{
    public class IT_HEAD: IStructBasic<IT_HEAD>
    {
        public string ID { get; set; }
        public string NAME { get; set; }

        public IT_HEAD GetT(IRfcStructure rfcStructure)
        {
            return new IT_HEAD()
            {
                ID = rfcStructure.GetString("ID"),
                NAME = rfcStructure.GetString("NAME")
            };
        }
    }
}
