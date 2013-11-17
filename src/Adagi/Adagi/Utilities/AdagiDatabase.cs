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
    }
}