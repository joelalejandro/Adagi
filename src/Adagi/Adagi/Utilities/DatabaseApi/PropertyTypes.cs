using Adagi.Models;
using MyCouch.Requests;
using MyCouch.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Adagi.Utilities.DatabaseApi
{
    public static class PropertyTypes
    {
        public async static Task<ViewQueryResponse<PropertyType>> Get()
        {
            using (var db = Database.Connect())
            {
                var query = new QueryViewRequest("propertytypes", "all").Configure(q => q.Limit(300).Reduce(false));
                return await db.Views.QueryAsync<PropertyType>(query);
            }
        }

        public async static Task<EntityResponse<PropertyType>> Post(PropertyType propertyType)
        {
            using (var db = Database.Connect())
            {
                var post = new PostEntityRequest<PropertyType>(propertyType);
                var result = await db.Entities.PostAsync<PropertyType>(post);
                return result;
            }
        }

        public async static Task<EntityResponse<PropertyType>> Delete(PropertyType propertyType)
        {
            using (var db = Database.Connect())
            {
                return await db.Entities.DeleteAsync<PropertyType>(propertyType);
            }
        }
    }
}