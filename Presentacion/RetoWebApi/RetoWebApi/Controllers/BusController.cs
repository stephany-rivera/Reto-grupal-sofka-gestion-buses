using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reto.Services;
using Reto.Infraestructure;
using Reto.Services.Models;

namespace RetoWebApi.Controllers
{
    [Route("api/Bus/{action}", Name = "Bus")]

    public class BusController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObtenerBuses()
        {
           var response = BusService.ObtenerBuses();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage CrearBus([FromBody] BusModel bus)
        {
            var response = BusService.CrearBus(bus);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }


    }
      
}