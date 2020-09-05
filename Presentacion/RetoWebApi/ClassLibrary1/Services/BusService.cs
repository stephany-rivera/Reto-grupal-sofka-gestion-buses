using Reto.Infraestructure;
using Reto.Services.Response.Entidad;
using Reto.Infraestructure.Access;
using System;
using System.Collections.Generic;
using System.Text;
using Reto.Services.Utilities;
using Reto.Services.Models;

namespace Reto.Services
{
    public class BusService
    {
        public static BusResponse ObtenerBuses()
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                List<Bus> buses = BusAccess.ObtenerBuses();
                var listaBuses = ConfigAutomapper.mapper.Map<List<BusModel>>(buses);
                return new BusResponse(listaBuses, true, mensajes);
            }
            else
            {
                return new BusResponse(null, false, mensajes);
            }
        }

        public static BusResponse CrearBus(BusModel busRequest)
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                var bus = ConfigAutomapper.mapper.Map<Bus>(busRequest);
                bus.CapacidadActual = 0;
                var busCreado = BusAccess.CrearBus(bus);
                List<BusModel> listaBus = new List<BusModel>();
                var busModel = ConfigAutomapper.mapper.Map<BusModel>(busCreado);
                listaBus.Add(busModel);
                return new BusResponse(listaBus, true, mensajes);
            }
            else
            {
                return new BusResponse(null, false, mensajes);
            }

        }
    }


}
