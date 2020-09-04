using Reto.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class RutaBusResponse : BaseResponse
    {
        public List <RutaBus> RutaBus { get; set; }

        public RutaBusResponse(List <RutaBus> rutaBus, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            RutaBus = rutaBus;
        }
    }
}
