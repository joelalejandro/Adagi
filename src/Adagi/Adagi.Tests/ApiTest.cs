using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using Adagi.Utilities;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MyCouch.Responses;
using Adagi.Models;

namespace Adagi.Tests
{
    [TestClass]
    public class ApiTest
    {
        protected HttpClient BuildClient()
        {
            var http = new HttpClient();
            http.BaseAddress = new Uri(Settings.Get("Adagi.Api.Host"));
            return http;
        }

        protected async Task<ViewQueryResponse<object>> GetViewResponse(HttpResponseMessage response)
        {
            string data = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ViewQueryResponse<object>>(data);
        }

        protected async Task<EntityResponse<object>> GetEntityResponse(HttpResponseMessage response)
        {
            string data = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<EntityResponse<object>>(data);
        }

        protected async Task<ViewQueryResponse<object>> Get(string request)
        {
            using (var http = BuildClient())
            {
                return await GetViewResponse(await http.GetAsync(request));
            }
        }

        protected async Task<EntityResponse<object>> Post<T>(string request, T obj)
        {
            using (var http = BuildClient())
            {
                return await GetEntityResponse(await http.PostAsJsonAsync<T>(request, obj));
            }
        }

        protected async Task<EntityResponse<object>> Delete(string request)
        {
            using (var http = BuildClient())
            {
                return await GetEntityResponse(await http.DeleteAsync(request));
            }
        }

        #region Properties API ####################################################################

        [TestMethod]
        [TestCategory("Properties API")]
        public async Task TestGetProperties()
        {
            ViewQueryResponse<object> response = await Get("properties/");
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsFalse(response.IsEmpty);
            Assert.IsTrue(response.IsSuccess);
        }

        [TestMethod]
        [TestCategory("Properties API")]
        public async Task TestGetExistingProperty()
        {
            ViewQueryResponse<object> response = await Get("properties/1234ABC");
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(response.RowCount == 1);
            Assert.IsFalse(response.IsEmpty);
            Assert.IsTrue(response.Rows[0].Key.ToString() == "1234ABC");
            Assert.IsTrue(response.IsSuccess);
        }

        [TestMethod]
        [TestCategory("Properties API")]
        public async Task TestGetNotExistingProperty()
        {
            ViewQueryResponse<object> response = await Get("properties/not_existing_code_ref");
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(response.RowCount == 0);
            Assert.IsTrue(response.IsEmpty);
        }

        [TestMethod]
        [TestCategory("Properties API")]
        public async Task TestPostDeleteProperty()
        {
            var property = new Property { ReferenceCode = "1234ABC", Type = new PropertyType { Name = "Home" } };
            var response = await Post<Property>("properties", property);
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.Created);

            var responseDelete = await Delete("property/" + response.Id);
            Assert.IsNull(responseDelete.Error);
            
        }

        #endregion

        #region Property Types API ################################################################

        [TestMethod]
        [TestCategory("Property Types API")]
        public async Task TestGetPropertyTypes()
        {
            ViewQueryResponse<object> response = await Get("propertytypes/");
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsFalse(response.IsEmpty);
            Assert.IsTrue(response.IsSuccess);
        }

        [TestMethod]
        [TestCategory("Property Types API")]
        public async Task TestPostDeletePropertyType()
        {
            var propertyType = new PropertyType { Name = "Test Property Type" };
            var response = await Post<PropertyType>("propertytypes", propertyType);
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.Created);

            var responseDelete = await Delete("propertytypes/" + response.Id);
            Assert.IsNull(responseDelete.Error);
        }

        #endregion

        #region Auth API ##########################################################################

        #endregion
    }
}
