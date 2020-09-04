using Reto.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class PasajeroResponse : BaseResponse
    {
        public List <Pasajero> Pasajero { get; set; }

        public PasajeroResponse(List <Pasajero> pasajero, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Pasajero = pasajero;
        }
    }
}
