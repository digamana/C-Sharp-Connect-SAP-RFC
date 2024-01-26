using SAP.Middleware.Connector;
using SapRfcConsole.Struct.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SapRfcConsole.Struct
{
    public static class Extension
    {
        public static T ToClass<T>(this IRfcStructure rfcStructure) where T : new()
        {
            var target = Activator.CreateInstance(typeof(T).GetTypeInfo());
            var props = target.GetType().GetProperties();
            foreach (var prop in props)
            {
                target.GetType().GetProperty(prop.Name).SetValue(target, rfcStructure.GetString(prop.Name));
            }
            T result = (T)target;
            return result;
        }
    }
    public class StructElement<T> where T: new()
    {
        public List<T> ToList { get;set; }
        public StructElement(IRfcTable _lstRfcTable)
        {
            ToList = new List<T>();
            foreach (var item in _lstRfcTable)
            {
                var Class = item.ToClass<T>();
                ToList.Add(Class);
            }
        }
    }
}
