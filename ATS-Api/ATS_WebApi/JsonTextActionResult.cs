using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Text;
using Newtonsoft.Json;
namespace ATS_WebApi
{
    public class JsonTextActionResult : IHttpActionResult
    {
        public HttpRequestMessage Request { get; }

        public object JsonText { get; }

        public JsonTextActionResult(HttpRequestMessage request, object jsonText)
        {
            Request = request;
            JsonText = jsonText;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute());
        }

        public HttpResponseMessage Execute()
        {
            if (JsonText == null)
                return this.Request.CreateResponse(HttpStatusCode.NotFound);
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(JsonText), Encoding.UTF8, "application/json");
            return response;
        }
    }
}