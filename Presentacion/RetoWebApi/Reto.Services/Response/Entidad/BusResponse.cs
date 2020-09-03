using Reto.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class BusResponse : BaseResponse
    {
        public List<Bus> Bus { get; set; }

        public BusResponse(List<Bus> bus, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Bus = bus;
        }
       
    }

  
}

