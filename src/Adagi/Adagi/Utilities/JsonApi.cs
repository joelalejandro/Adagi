using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Adagi.Utilities
{
    public static class JsonApi
    {
        public async static Task<object> GetProperties()
        {
            return Json.Reserialize(await Database.GetProperties());
        }

        public async static Task<object> GetProperties(string ReferenceCode)
        {
            return Json.Reserialize(await Database.GetProperties(ReferenceCode));
        }
    }
}