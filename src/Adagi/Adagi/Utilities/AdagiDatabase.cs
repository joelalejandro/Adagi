using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCouch;
using Adagi.Models;
using MyCouch.Requests;
using System.Threading.Tasks;
using MyCouch.Responses;
using System.Web.Script.Serialization;

namespace Adagi.Utilities
{
    public static class Database
    {
        public static Client Connect()
        {
            var uri = new MyCouchUriBuilder(Settings.Get("Adagi.Database.Host"));
            uri.SetBasicCredentials(Settings.Get("Adagi.Database.Username"), Settings.Get("Adagi.Database.Password"));
            uri.SetDbName(Settings.Get("Adagi.Database.Name"));
            return new Client(uri.Build());
        }

        public async static Task<ViewQueryResponse<Property>> GetProperties()
        {
            using (var db = Database.Connect())
            {
                var query = new QueryViewRequest("Properties", "All").Configure(q => q.Limit(300).Reduce(false));
                return await db.Views.QueryAsync<Property>(query);
            }
        }

        public async static Task<ViewQueryResponse<Property>> GetProperties(string ReferenceCode)
        {
            using (var db = Database.Connect())
            {
                var query = new QueryViewRequest("Properties", "All").Configure(q => q.Key<string>(ReferenceCode).Reduce(false));
                return await db.Views.QueryAsync<Property>(query);
            }
        }
    }
}