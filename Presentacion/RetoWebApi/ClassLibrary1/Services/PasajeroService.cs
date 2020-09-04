using Reto.Infraestructure;
using Reto.Infraestructure.Access;
using Reto.Services.Models;
using Reto.Services.Response.Entidad;
using Reto.Services.Utilities;
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

        public static PasajeroResponse CrearPasajero(PasajeroModel pasajeroModel)
        {
            var mensajes = new List<Mensaje>();
            var rutas = RutaAccess.ObtenerRuta();
            var municipios = MunicipioAccess.ObtenerMunicipios();
            var municipioDestino = municipios.Where(x => x.Nombre.Contains(pasajeroModel.NombreDestino)).FirstOrDefault();
            var rutaDestino = rutas.Where(x => x.DestinoId == municipioDestino.MunicipioId).FirstOrDefault();

            if (rutaDestino == null)
            {
                //rutaDestino = rutas.Where(x => x.Transbordo == municipioDestino.MunicipioId).FirstOrDefault();

            }
           
            var rutaBus = RutaBusAccess.ObtenerRutaBus().Where(x => x.RutaId == rutaDestino.RutaId).ToList();


            foreach (var ruta in rutaBus)
            {
                
                var bus = BusAccess.ObtenerBus((int)ruta.BusId);
                var trasbordo = rutas.Where(x => x.RutaId == ruta.RutaId).FirstOrDefault();
                if (bus.CapacidadActual < (bus.Capacidad / 2) && pasajeroModel.Tapabocas == true && trasbordo.Transbordo == false)
                {
                    pasajeroModel.RutaBusId = ruta.RutaBusId;
                    pasajeroModel.SillaAsignada = (bus.CapacidadActual*2)+1;
                    bus.CapacidadActual++;
                    BusAccess.ActualizarBus(bus);
                    break;
                }
                
         

            }
            if (pasajeroModel.SillaAsignada == null)
                mensajes.Add(new Mensaje("No existen buses disponibles para esta ruta"));

            if (pasajeroModel.Tapabocas == false)
                mensajes.Add(new Mensaje("No cumple con los requisitos establecidos por el gobierno"));





            if (mensajes.Count == 0)
            {
                var pasajero = ConfigAutomapper.mapper.Map<Pasajero>(pasajeroModel);
              
                    PasajeroAccess.CrearPasajero(pasajero);
                    List<Pasajero> pasajeroLista = new List<Pasajero>();
                    pasajeroLista.Add(pasajero);
                    mensajes.Add(new Mensaje("Se ha agregado el pasajero exitosamente"));
                    return new PasajeroResponse(pasajeroLista, true, mensajes);
                
               
            }
            else
            {
                return new PasajeroResponse(null, false, mensajes);
            }

        }


    }
}
