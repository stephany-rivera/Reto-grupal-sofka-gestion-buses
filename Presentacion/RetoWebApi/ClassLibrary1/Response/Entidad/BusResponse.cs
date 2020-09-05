using Reto.Infraestructure;
using Reto.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class BusResponse : BaseResponse
    {
        public List<BusModel> Bus { get; set; }

        public BusResponse(List<BusModel> bus, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Bus = bus;
        }
       
    }

  
}

