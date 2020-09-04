using Reto.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class RutaResponse : BaseResponse
    {
        public List <Ruta> Ruta { get; set; }

        public RutaResponse(List <Ruta> ruta, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Ruta = ruta;
        }
    }
}
