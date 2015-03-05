using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace beckAppCordova.Controllers
{
    public class CordovaController : ApiController
    {
        // GET: api/Cordova
        public IEnumerable<string> Get()
        {
            return new string[] { "Renato", "Cantarino" };
        }

        // GET: api/Cordova/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cordova
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cordova/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cordova/5
        public void Delete(int id)
        {
        }
    }
}