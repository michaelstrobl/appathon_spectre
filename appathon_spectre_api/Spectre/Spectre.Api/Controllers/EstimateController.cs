using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Spectre.Api.Controllers
{
    public class EstimateController : ApiController
    {
        // GET api/values
        public object Get()
        {
            return new
            {
                worth = 300000d,
                currency = "EUR",
                mapImageUrl = "http://maps.googleapis.com/maps/api/staticmap?center=Piazza+Marconi+2+87989+Milano+Lombardia+Italy&zoom=16&size=600x300&maptype=roadmap"
            };
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
