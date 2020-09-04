using System.Net;
using System.Net.Http;
using System.Web.Http;
using Reto.Services;
using Reto.Infraestructure;

namespace RetoWebApi.Controllers
{
    [Route("api/[controller]")]

    public class MunicipioController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObtenerMunicipio()
        {
            var response = MunicipioService.ObtenerMunicipio();
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }

        [HttpPost]
        public HttpResponseMessage CrearMunicipio([FromBody] Municipio Municipio)
        {
            var response = MunicipioService.CrearMunicipio(Municipio);
            HttpResponseMessage result = Request.CreateResponse(HttpStatusCode.OK, response);
            return result;
        }


    }
}