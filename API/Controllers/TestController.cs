using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [Route("[Products]")]
    public class TestController : ApiController
    {
        [HttpGet]
        [SwaggerOperation(operationId: "getA")]
        public IEnumerable<string> List()
        {
            return new string[] { "kalyani", "Ravi" };
        }


        [Route("GetProductByID")]
        [HttpPost]
        public IEnumerable<string> GetProductByID(int id)
        {
            return new string[] { "kalyani"};
        }
    }
}