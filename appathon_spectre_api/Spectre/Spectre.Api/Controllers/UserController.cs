using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Spectre.Api.Controllers
{
    public class UserController : ApiController
    {
        // GET api/values
        public JObject Get()
        {
            var request = "https://ucg-apimanager.axwaycloud.net:8065/users/v1/current/ma.miller.85";
            var client = new WebClient();
            client.Headers.Add("keyId", "abdee8a1-21a7-472a-929e-1be692a54ea2");
            var json = client.DownloadString(request);

            var user = JObject.Parse(json);

            return user;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
