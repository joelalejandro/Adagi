using Adagi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Adagi.Utilities.JsonApi
{
    public static class PropertyTypes
    {
        public async static Task<object> Get()
        {
            return Json.Reserialize(await DatabaseApi.PropertyTypes.Get());
        }

        public async static Task<object> Post(PropertyType propertyType)
        {
            return Json.Reserialize(await DatabaseApi.PropertyTypes.Post(propertyType));
        }

        public async static Task<object> Delete(PropertyType propertyType)
        {
            return Json.Reserialize(await DatabaseApi.PropertyTypes.Delete(propertyType));
        }
    }
}