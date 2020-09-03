using Reto.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    class RutaResponse : BaseResponse
    {
        public Ruta Ruta { get; set; }

        public RutaResponse(Ruta ruta, bool success = false, IEnumerable<Mensaje> mensajes = null) : base(success, mensajes)
        {
            Ruta = ruta;
        }
    }
}
