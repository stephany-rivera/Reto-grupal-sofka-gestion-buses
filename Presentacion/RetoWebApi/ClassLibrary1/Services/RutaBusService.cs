using Reto.Infraestructure;
using Reto.Infraestructure.Access;
using Reto.Services.Models;
using Reto.Services.Response.Entidad;
using Reto.Services.Utilities;
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
                var listaRutaBuses = ConfigAutomapper.mapper.Map<List<RutaBusModel>>(RutaBuses);
                return new RutaBusResponse(listaRutaBuses, true, mensajes);
            }
            else
            {
                return new RutaBusResponse(null, false, mensajes);
            }
        }

        public static RutaBusResponse CrearRutaBus(RutaBusModel rutaBusRequest)
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                var rutaBus = ConfigAutomapper.mapper.Map<RutaBus>(rutaBusRequest);
                var rutaBusCreado = RutaBusAccess.CrearRutaBus(rutaBus);
                var rutaBusModel = ConfigAutomapper.mapper.Map<RutaBusModel>(rutaBusCreado);
                List<RutaBusModel> ListaBus = new List<RutaBusModel>();
                ListaBus.Add(rutaBusModel);
                return new RutaBusResponse(ListaBus, true, mensajes);
            }
            else
            {
                return new RutaBusResponse(null, false, mensajes);
            }

        }

    }
}
