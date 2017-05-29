using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiPuc.Controllers
{

    public class ValuesController : ApiController
    {

        List<Models.Student> list = new List<Models.Student>();

        // GET api/values
        public List<Models.Student> Get()
        {
            list.Add(new Models.Student("Pablo Dias", "28", "Brazil", "Belo Horizonte"));
            return list;
        }

        // GET api/values/5
        public Models.Student Get(int id)
        {
            return list[id];
        }

        // POST api/values
        public void Post([FromBody]Models.Student student)
        {
            list.Add(new Models.Student(student.Name, student.Age, student.Country, student.City));
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
