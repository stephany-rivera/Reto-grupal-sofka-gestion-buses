using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reto.Services;
using Reto.Infraestructure;
using Reto.Services.Models;

namespace RetoWebApi.Controllers
{
    [Route("api/Pasajero/{action}", Name = "Pasajero")]

    public class PasajeroController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObtenerPasajeros()
        {
            var response = PasajeroService.ObtenerPasajeros();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage ConsultarPasajero([FromBody] PasajeroModel pasajeroModel)
        {
            var response = PasajeroService.ConsultarPasajero(pasajeroModel);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }


        [HttpPost]
        public HttpResponseMessage CrearPasajero([FromBody] PasajeroModel pasajeroModel)
        {
            var response = PasajeroService.CrearPasajero(pasajeroModel);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }


    }
}