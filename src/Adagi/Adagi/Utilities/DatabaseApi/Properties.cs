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
    public static class Properties
    {
        public async static Task<ViewQueryResponse<Property>> Get()
        {
            using (var db = Database.Connect())
            {
                var query = new QueryViewRequest("properties", "all").Configure(q => q.Limit(300).Reduce(false));
                return await db.Views.QueryAsync<Property>(query);
            }
        }

        public async static Task<ViewQueryResponse<Property>> Get(string ReferenceCode)
        {
            using (var db = Database.Connect())
            {
                var query = new QueryViewRequest("properties", "all").Configure(q => q.Key<string>(ReferenceCode).Reduce(false));
                return await db.Views.QueryAsync<Property>(query);
            }
        }

        public async static Task<EntityResponse<Property>> Post(Property property)
        {
            using (var db = Database.Connect())
            {
                var post = new PostEntityRequest<Property>(property);
                var result = await db.Entities.PostAsync<Property>(property);
                return result;
            }
        }

        public async static Task<EntityResponse<Property>> Delete(Property propertyType)
        {
            using (var db = Database.Connect())
            {
                return await db.Entities.DeleteAsync<Property>(propertyType);
            }
        }

    }
}