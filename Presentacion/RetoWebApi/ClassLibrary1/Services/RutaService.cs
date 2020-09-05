using Reto.Infraestructure;
using Reto.Infraestructure.Access;
using Reto.Services.Models;
using Reto.Services.Response.Entidad;
using Reto.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services
{
    public class RutaService
    {

        public static RutaResponse ObtenerRutas()
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                List<Ruta> Rutas = RutaAccess.ObtenerRutas();
                var rutaModel = ConfigAutomapper.mapper.Map<List<RutaModel>>(Rutas);
                return new RutaResponse(rutaModel, true, mensajes);
            }
            else
            {
                return new RutaResponse(null, false, mensajes);
            }
        }

        public static RutaResponse CrearRuta(RutaModel rutaRequest)
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                var ruta = ConfigAutomapper.mapper.Map<Ruta>(rutaRequest);
                var rutaCreado = RutaAccess.CrearRuta(ruta);
                var rutaModel = ConfigAutomapper.mapper.Map<RutaModel>(rutaCreado);
                List<RutaModel> listaRuta = new List<RutaModel>();
                listaRuta.Add(rutaModel);
                return new RutaResponse(listaRuta, true, mensajes);
            }
            else
            {
                return new RutaResponse(null, false, mensajes);
            }

        }
    }
}
