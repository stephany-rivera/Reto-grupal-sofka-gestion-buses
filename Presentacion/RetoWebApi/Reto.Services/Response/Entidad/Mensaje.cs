using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Response.Entidad
{
    public class Mensaje
    {
        public string Description { get;  }

        public Mensaje(string description)
        {
            Description = description;
        }
    }
}
