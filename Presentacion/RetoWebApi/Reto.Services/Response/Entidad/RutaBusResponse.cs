using Reto.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    class RutaBusResponse : BaseResponse
    {
        public RutaBus RutaBus { get; set; }

        public RutaBusResponse(RutaBus rutaBus, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            RutaBus = rutaBus;
        }
    }
}
