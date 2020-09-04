using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reto.Services;
using Reto.Infraestructure;

namespace RetoWebApi.Controllers
{
    [Route("api/[controller]")]

    public class PasajeroController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObtenerPasajero()
        {
            var response = PasajeroService.ObtenerPasajero();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage CrearPasajero([FromBody] Pasajero Pasajero)
        {
            var response = PasajeroService.CrearPasajero(Pasajero);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }


    }
}