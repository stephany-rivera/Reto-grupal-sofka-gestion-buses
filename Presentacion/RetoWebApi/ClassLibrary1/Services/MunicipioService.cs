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
    public class MunicipioService
    {

        public static MunicipioResponse ObtenerMunicipio()
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                List<Municipio> municipios = MunicipioAccess.ObtenerMunicipios();
                var listaMunicipios = ConfigAutomapper.mapper.Map<List<MunicipioModel>>(municipios);
                return new MunicipioResponse(listaMunicipios, true, mensajes);
            }
            else
            {
                return new MunicipioResponse(null, false, mensajes);
            }
        }

        public static MunicipioResponse CrearMunicipio(Municipio municipio)
        {
            var mensajes = new List<Mensaje>();
            if (mensajes.Count == 0)
            {
                var municipioCreado = MunicipioAccess.CrearMunicipio(municipio);
                var municipioModel = ConfigAutomapper.mapper.Map<MunicipioModel>(municipioCreado);

                List<MunicipioModel> listaMunicipio = new List<MunicipioModel>();
                listaMunicipio.Add(municipioModel);

                return new MunicipioResponse(listaMunicipio, true, mensajes);
            }
            else
            {
                return new MunicipioResponse(null, false, mensajes);
            }

        }


    }
}
