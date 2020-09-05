using Reto.Infraestructure;
using Reto.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class RutaBusResponse : BaseResponse
    {
        public List <RutaBusModel> RutaBus { get; set; }

        public RutaBusResponse(List <RutaBusModel> rutaBus, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            RutaBus = rutaBus;
        }
    }
}
