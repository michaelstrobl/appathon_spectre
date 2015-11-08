using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleOAuth;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
        public JObject Get(string id)
        {
            var request = "https://ucg-apimanager.axwaycloud.net:8065/users/v1/current/" + id;
            var client = new WebClient();
            client.Headers.Add("keyId", "abdee8a1-21a7-472a-929e-1be692a54ea2");
            var json = client.DownloadString(request);

            var user = JObject.Parse(json);

            return user;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            try
            {
                var accessToken = "9921809f-be51-4710-ac49-dbef132deb2b";
                var myUri = new Uri("https://api.gini.net/documents");
                var myWebRequest = WebRequest.Create(myUri);
                var myHttpWebRequest = (HttpWebRequest)myWebRequest;
                myHttpWebRequest.Method = "POST";
                myHttpWebRequest.PreAuthenticate = true;
                myHttpWebRequest.Headers.Add("Authorization", "BEARER " + accessToken);
                myHttpWebRequest.Accept = "application/vnd.gini.v1+json";

                var myWebResponse = myWebRequest.GetResponse();
                var responseStream = myWebResponse.GetResponseStream();
                var myStreamReader = new StreamReader(responseStream, Encoding.Default);
                var json = myStreamReader.ReadToEnd();

                responseStream.Close();
                myWebResponse.Close();
            }
            catch
            {
            }
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
