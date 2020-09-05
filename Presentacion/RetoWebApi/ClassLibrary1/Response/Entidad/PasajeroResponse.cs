using Reto.Infraestructure;
using Reto.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class PasajeroResponse : BaseResponse
    {
        public List <PasajeroModel> Pasajero { get; set; }

        public PasajeroResponse(List <PasajeroModel> pasajero, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Pasajero = pasajero;
        }
    }
}
