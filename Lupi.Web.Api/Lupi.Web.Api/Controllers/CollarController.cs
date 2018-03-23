using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Lupi.Web.Api.Controllers
{
    public class CollarController : ApiController
    {
        // GET: api/Collar
        public HttpResponseMessage Get([FromUri] Guid id)
        {
            HttpRequestHeaders headers = this.Request.Headers;
            string token = string.Empty;

            if (headers.Contains("token"))
            {
                token = headers.GetValues("token").First();
                if(token != "secreto")
                {
                    return Request.CreateResponse(HttpStatusCode.Unauthorized);
                }

                var responde = Request.CreateResponse(HttpStatusCode.OK,"value"+id);
                responde.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    Public = true,
                    MaxAge = new TimeSpan(1,0,0,0)
                };


            }

            return null;
        }

        // GET: api/Collar/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Collar
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Collar/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Collar/5
        public void Delete(int id)
        {
        }
    }
}
