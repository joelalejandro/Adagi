using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyCouch.Responses;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Adagi.Utilities.JsonApi;
using Adagi.Utilities;
using Adagi.Models;

namespace Adagi.API
{
    public class PropertyTypesController : ApiController
    {
        // GET api/propertytypes
        public async Task<object> Get()
        {
            return await PropertyTypes.Get();
        }

        // GET api/propertytypes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/propertytypes
        public async Task<object> Post([FromBody]PropertyType value)
        {
            return await PropertyTypes.Post(value);
        }

        // PUT api/propertytypes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/propertytypes/5
        public void Delete(int id)
        {
        }
    }
}
