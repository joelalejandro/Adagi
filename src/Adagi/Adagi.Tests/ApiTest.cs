using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using Adagi.Utilities;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MyCouch.Responses;

namespace Adagi.Tests
{
    [TestClass]
    public class ApiTest
    {
        protected async Task<ViewQueryResponse<object>> Get(string request)
        {
            var http = new HttpClient();
            http.BaseAddress = new Uri(Settings.Get("Adagi.Api.Host"));
            HttpResponseMessage response = await http.GetAsync(request);
            string data = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ViewQueryResponse<object>>(data);
        }

        #region Properties API ####################################################################

        [TestMethod]
        [TestCategory("Properties API")]
        public async Task TestGetProperties()
        {
            ViewQueryResponse<object> response = await Get("properties/");
            Assert.IsNull(response.Error);
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
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

        #endregion
    }
}
