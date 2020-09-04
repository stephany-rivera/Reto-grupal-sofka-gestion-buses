using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reto.Services;
using Reto.Infraestructure;

namespace RetoWebApi.Controllers
{
    [Route("api/[controller]")]
    public class RutaController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObtenerRuta()
        {
            var response = RutaService.ObtenerRuta();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage CrearRuta([FromBody] Ruta Ruta)
        {
            var response = RutaService.CrearRuta(Ruta);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }


    }
}