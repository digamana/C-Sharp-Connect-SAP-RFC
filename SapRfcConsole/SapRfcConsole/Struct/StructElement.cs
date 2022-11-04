using SAP.Middleware.Connector;
using SapRfcConsole.Struct.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapRfcConsole.Struct
{
    public class StructElement<T> where T: IStructBasic<T>,new()
    {
        public List<T> ToList { get;set; }
        public StructElement(IRfcTable _lstRfcTable)
        {
            T t = new T();
            ToList = new List<T>();
            foreach (var item in _lstRfcTable)
            {
                ToList.Add(t.GetT(item));
            }
        }
    }
}
