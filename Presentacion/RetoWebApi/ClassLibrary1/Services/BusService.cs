using Reto.Infraestructure;
using Reto.Services.Response.Entidad;
using Reto.Infraestructure.Access;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services
{
    public class BusService
    {
        public static BusResponse ObtenerBus()
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                List<Bus> buses = BusAccess.ObtenerBus();
                return new BusResponse(buses, true, mensajes);
            }
            else
            {
                return new BusResponse(null, false, mensajes);
            }
        }

        public static BusResponse CrearBus(Bus bus)
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                BusAccess.CrearBus(bus);
                return new BusResponse(null, true, mensajes);
            }
            else
            {
                return new BusResponse(null, false, mensajes);
            }

        }
    }


}
