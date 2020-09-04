using Reto.Infraestructure;
using Reto.Infraestructure.Access;
using Reto.Services.Response.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services
{
    public class RutaService
    {

        public static RutaResponse ObtenerRuta()
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                List<Ruta> Rutas = RutaAccess.ObtenerRuta();
                return new RutaResponse(Rutas, true, mensajes);
            }
            else
            {
                return new RutaResponse(null, false, mensajes);
            }
        }

        public static RutaResponse CrearRuta(Ruta Ruta)
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                RutaAccess.CrearRuta(Ruta);
                return new RutaResponse(null, true, mensajes);
            }
            else
            {
                return new RutaResponse(null, false, mensajes);
            }

        }
    }
}
