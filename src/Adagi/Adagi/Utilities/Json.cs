using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Adagi.Utilities
{
    public class Json
    {
        public static object Reserialize(object obj)
        {
            var js = new JavaScriptSerializer();
            return js.DeserializeObject(js.Serialize(obj));
        }

        public static T Deserealize<T>(string body)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(body);
        }
    }
}