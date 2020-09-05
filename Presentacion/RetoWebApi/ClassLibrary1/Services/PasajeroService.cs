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
        public static PasajeroResponse ObtenerPasajeros()
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                List<Pasajero> Pasajeros = PasajeroAccess.ObtenerPasajeros();
                var PasajerosModel = ConfigAutomapper.mapper.Map<List<PasajeroModel>>(Pasajeros);
                return new PasajeroResponse(PasajerosModel, true, mensajes);
            }
            else
            {
                return new PasajeroResponse(null, false, mensajes);
            }
        }

        public static PasajeroResponse ConsultarPasajero(PasajeroModel pasajeroModel)
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                List<Pasajero> Pasajeros = PasajeroAccess.ObtenerPasajeros();
                var municipios = MunicipioAccess.ObtenerMunicipios();
                var pasajero = Pasajeros.Where(x => x.NombreCompleto.ToLower().Contains(pasajeroModel.NombreCompleto.ToLower())).FirstOrDefault();

                var rutaBus = RutaBusAccess.ObtenerRutaBus().Where(x => x.RutaBusId == pasajero.RutaBusId).FirstOrDefault();
                var rutaLista = RutaAccess.ObtenerRuta();
                var rutaConsultada = rutaLista.Where(x => x.RutaId == rutaBus.RutaId).FirstOrDefault();
                var municipioOrigen = municipios.Where(x => x.MunicipioId == rutaConsultada.OrigenId).FirstOrDefault();
                var municipioDestino = municipios.Where(x => x.MunicipioId == rutaConsultada.DestinoId).FirstOrDefault();

                PasajeroModel pasajeroConsultado = ConfigAutomapper.mapper.Map<PasajeroModel>(pasajero);
                pasajeroConsultado.PasajeroOrigen = municipioOrigen.Nombre;
                pasajeroConsultado.PasajeroDestino = municipioDestino.Nombre;

                List<PasajeroModel> pasajeroListaModel = new List<PasajeroModel>();
                pasajeroListaModel.Add(pasajeroConsultado);
                return new PasajeroResponse(pasajeroListaModel, true, mensajes);
            }
            else
            {
                return new PasajeroResponse(null, false, mensajes);
            }
        }


        public static PasajeroResponse CrearPasajero(PasajeroModel pasajeroModel)
        {
            var mensajes = new List<Mensaje>();
            List<Ruta> rutaDestino = new List<Ruta>();
            var rutas = RutaAccess.ObtenerRuta();
            var municipios = MunicipioAccess.ObtenerMunicipios();
            var municipioDestino = municipios.Where(x => x.Nombre.ToLower().Contains(pasajeroModel.PasajeroDestino.ToLower())).FirstOrDefault();
            var municipioOrigen = municipios.Where(x => x.Nombre.ToLower().Contains(pasajeroModel.PasajeroOrigen.ToLower())).FirstOrDefault();
            if (municipioOrigen == null || municipioDestino == null)
            {
                mensajes.Add(new Mensaje("El Municipio de Origen o Destino no se encuentran registrados "));
            }
            else
            {
                rutaDestino = rutas.Where(x => x.DestinoId == municipioDestino.MunicipioId && x.OrigenId == municipioOrigen.MunicipioId).ToList();
            }
            if (rutaDestino == null)
            {
                rutaDestino = rutas.Where(x => x.TrasbordoMunicipioId == municipioDestino.MunicipioId && x.OrigenId == municipioOrigen.MunicipioId).ToList();
            }
            if (rutaDestino.Count > 0)
            {
                foreach (var item in rutaDestino)
                {
                    var rutaBus = RutaBusAccess.ObtenerRutaBus().Where(x => x.RutaId == item.RutaId).ToList();
                    foreach (var ruta in rutaBus)
                    {
                        var bus = BusAccess.ObtenerBus((int)ruta.BusId);
                        var trasbordo = rutas.Where(x => x.RutaId == ruta.RutaId).FirstOrDefault();
                        if (bus.CapacidadActual < (bus.Capacidad / 2) && pasajeroModel.Tapabocas == true && trasbordo.Trasbordo == false)
                        {
                            pasajeroModel.RutaBusId = ruta.RutaBusId;
                            pasajeroModel.SillaAsignada = (bus.CapacidadActual * 2) + 1;
                            bus.CapacidadActual++;
                            BusAccess.ActualizarBus(bus);
                            break;
                        }
                        else if (bus.CapacidadActual < (bus.Capacidad / 2) && pasajeroModel.Tapabocas == true && trasbordo.Trasbordo == true)
                        {
                            pasajeroModel.RutaBusId = ruta.RutaBusId;
                            pasajeroModel.SillaAsignada = (bus.CapacidadActual * 2) + 1;
                            bus.CapacidadActual++;
                            BusAccess.ActualizarBus(bus);
                            break;
                        }
                    }
                    if (pasajeroModel.SillaAsignada != null)
                    {
                        break;
                    }
                    

                }
                if (pasajeroModel.SillaAsignada == null)
                    mensajes.Add(new Mensaje("No existen buses disponibles para esta ruta"));

                if (pasajeroModel.Tapabocas == false)
                    mensajes.Add(new Mensaje("No cumple con los requisitos establecidos por el gobierno"));

            }
            else
            {
                mensajes.Add(new Mensaje("No se encuentran rutas relacionadas con el municipio de origen"));
            }










            if (mensajes.Count == 0)
            {
                var pasajero = ConfigAutomapper.mapper.Map<Pasajero>(pasajeroModel);

                PasajeroAccess.CrearPasajero(pasajero);
                List<PasajeroModel> pasajeroLista = new List<PasajeroModel>();
                pasajeroModel = ConfigAutomapper.mapper.Map<PasajeroModel>(pasajero);
                pasajeroModel.PasajeroOrigen = municipioOrigen.Nombre;
                pasajeroModel.PasajeroDestino = municipioDestino.Nombre;

                pasajeroLista.Add(pasajeroModel);
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
