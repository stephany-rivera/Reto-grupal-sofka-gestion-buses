using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reto.Services;
using Reto.Infraestructure;
using Reto.Services.Models;

namespace RetoWebApi.Controllers
{
    [Route("api/Ruta/{action}", Name = "Ruta")]
    public class RutaController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObtenerRutas()
        {
            var response = RutaService.ObtenerRutas();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage CrearRuta([FromBody] RutaModel Ruta)
        {
            var response = RutaService.CrearRuta(Ruta);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }


    }
}