using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProject1_Web.Controllers
{
    public class NoteApiController : ApiController
    {
        // GET: api/NoteApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/NoteApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NoteApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/NoteApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/NoteApi/5
        public void Delete(int id)
        {
        }
    }
}
