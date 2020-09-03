using System.Net;
using System.Net.Http;
using System.Web.Http;
using ;
using Reto.Services;

namespace RetoWebApi.Controllers
{
    [Route("api/[controller]")]

    public class BusController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObtenerPruebas()
        {
           var response = BusService.ObtenerPruebas();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }
    }
      
}