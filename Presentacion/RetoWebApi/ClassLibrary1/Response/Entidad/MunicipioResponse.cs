using Reto.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class MunicipioResponse : BaseResponse
    {
        public List <Municipio> Municipio { get; set; }

        public MunicipioResponse(List<Municipio> municipio, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Municipio = municipio;
        }
    }
}
