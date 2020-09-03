using Reto.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    class PasajeroResponse : BaseResponse
    {
        public Pasajero Pasajero { get; set; }

        public PasajeroResponse(Pasajero pasajero, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Pasajero = pasajero;
        }
    }
}
