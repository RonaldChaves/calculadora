using System.Collections.Generic;
using System.Web.Http;

namespace ApiService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { " ", " " };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            return "Deu certo!!";
        }

        // PUT api/values/5
        public string Put(int id, [FromBody] string value)
        {
            return "Deu certo a atualização";
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
