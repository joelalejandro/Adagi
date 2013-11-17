using Adagi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Adagi.Utilities.JsonApi
{
    public static class Properties
    {
        public async static Task<object> Get()
        {
            return Json.Reserialize(await DatabaseApi.Properties.Get());
        }

        public async static Task<object> Get(string ReferenceCode)
        {
            return Json.Reserialize(await DatabaseApi.Properties.Get(ReferenceCode));
        }

        public async static Task<object> Post(Property property)
        {
            return Json.Reserialize(await DatabaseApi.Properties.Post(property));
        }
    }
}