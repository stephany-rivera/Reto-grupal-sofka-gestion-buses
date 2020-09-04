using Reto.Infraestructure;
using Reto.Infraestructure.Access;
using Reto.Services.Response.Entidad;
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
                return new MunicipioResponse(municipios, true, mensajes);
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
                MunicipioAccess.CrearMunicipio(municipio);
                return new MunicipioResponse(null, true, mensajes);
            }
            else
            {
                return new MunicipioResponse(null, false, mensajes);
            }

        }


    }
}
