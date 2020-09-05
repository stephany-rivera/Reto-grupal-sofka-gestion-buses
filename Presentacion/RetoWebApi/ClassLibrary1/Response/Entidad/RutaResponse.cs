using Reto.Infraestructure;
using Reto.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class RutaResponse : BaseResponse
    {
        public List <RutaModel> Ruta { get; set; }

        public RutaResponse(List<RutaModel> ruta, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Ruta = ruta;
        }
    }
}
