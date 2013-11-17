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
                var query = new QueryViewRequest("Properties", "All").Configure(q => q.Limit(300).Reduce(false));
                return await db.Views.QueryAsync<Property>(query);
            }
        }

        public async static Task<ViewQueryResponse<Property>> Get(string ReferenceCode)
        {
            using (var db = Database.Connect())
            {
                var query = new QueryViewRequest("Properties", "All").Configure(q => q.Key<string>(ReferenceCode).Reduce(false));
                return await db.Views.QueryAsync<Property>(query);
            }
        }
    }
}