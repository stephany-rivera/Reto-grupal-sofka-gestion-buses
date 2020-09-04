using Reto.Infraestructure;
using Reto.Infraestructure.Access;
using Reto.Services.Response.Entidad;
using System.Collections.Generic;

namespace Reto.Services
{
    public class RutaBusService
    {
        public static RutaBusResponse ObtenerRutaBus()
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                List<RutaBus> RutaBuses = RutaBusAccess.ObtenerRutaBus();
                return new RutaBusResponse(RutaBuses, true, mensajes);
            }
            else
            {
                return new RutaBusResponse(null, false, mensajes);
            }
        }

        public static RutaBusResponse CrearRutaBus(RutaBus RutaBus)
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                RutaBusAccess.CrearRutaBus(RutaBus);
                return new RutaBusResponse(null, true, mensajes);
            }
            else
            {
                return new RutaBusResponse(null, false, mensajes);
            }

        }

    }
}
