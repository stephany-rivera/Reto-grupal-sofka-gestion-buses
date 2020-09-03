using Reto.Services.Response.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response
{

        public abstract class BaseResponse
        {
            public bool Success { get; }
            public IEnumerable<Mensaje> Mensajes { get; }

            protected BaseResponse(bool success = false, IEnumerable<Mensaje> mensajes = null)
            {
                Success = success;
                Mensajes = mensajes;
            }
        }
    
}
