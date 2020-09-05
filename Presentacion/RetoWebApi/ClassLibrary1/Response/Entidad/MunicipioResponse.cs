using Reto.Infraestructure;
using Reto.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class MunicipioResponse : BaseResponse
    {
        public List <MunicipioModel> Municipio { get; set; }

        public MunicipioResponse(List<MunicipioModel> municipio, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Municipio = municipio;
        }
    }
}
