using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyCouch;
using Adagi.Models;
using Adagi.Utilities;
using System.Threading.Tasks;
using MyCouch.Responses;
using System.Runtime.Serialization;

namespace Adagi.API
{
    public class PropertiesController : ApiController
    {
        // GET api/properties
        public async Task<object> Get()
        {
            return await JsonApi.GetProperties();
        }

        // GET api/properties/ABC213
        public async Task<object> Get(string id)
        {
            return await JsonApi.GetProperties(id);
        }

        // POST api/properties
        public void Post([FromBody]string value)
        {
        }

        // PUT api/properties/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/properties/5
        public void Delete(int id)
        {
        }
    }
}
