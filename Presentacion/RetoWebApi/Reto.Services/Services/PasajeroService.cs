using Reto.Infraestructure;
using Reto.Infraestructure.Access;
using Reto.Services.Response.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reto.Services
{
    public class PasajeroService
    {
        public static PasajeroResponse ObtenerPasajero()
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {                
                List<Pasajero> Pasajeros = PasajeroAccess.ObtenerPasajeros();
                return new PasajeroResponse(Pasajeros, true, mensajes);
            }
            else
            {
                return new PasajeroResponse(null, false, mensajes);
            }
        }

        public static PasajeroResponse CrearPasajero(Pasajero Pasajero)
        {
            var mensajes = new List<Mensaje>();
            var rutas = RutaAccess.ObtenerRuta();
            var rutaBus = RutaBusAccess.ObtenerRutaBus();
            //rutas.Where(x=> x.Nombre == Pasajero.)



            if (mensajes.Count == 0)
            {












                PasajeroAccess.CrearPasajero(Pasajero);
                return new PasajeroResponse(null, true, mensajes);
            }
            else
            {
                return new PasajeroResponse(null, false, mensajes);
            }

        }


    }
}
