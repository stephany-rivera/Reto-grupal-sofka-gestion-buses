using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reto.Services;
using Reto.Infraestructure;

namespace RetoWebApi.Controllers
{
    [Route("api/[controller]")]
    public class RutaBusController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObtenerRutaBus()
        {
            var response = RutaBusService.ObtenerRutaBus();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage CrearRutaBus([FromBody] RutaBus RutaBus)
        {
            var response = RutaBusService.CrearRutaBus(RutaBus);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }


    }
}