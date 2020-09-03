using Reto.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    class MunicipioResponse : BaseResponse
    {
        public Municipio Municipio { get; set; }

        public MunicipioResponse(Municipio municipio, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Municipio = municipio;
        }
    }
}
