using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reto.Services;
using Reto.Infraestructure;

namespace RetoWebApi.Controllers
{
    [Route("api/[controller]")]

    public class BusController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObtenerBus()
        {
           var response = BusService.ObtenerBuses();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage CrearBus([FromBody] Bus bus)
        {
            var response = BusService.CrearBus(bus);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }


    }
      
}