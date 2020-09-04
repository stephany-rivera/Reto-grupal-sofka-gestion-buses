using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Models
{
    public class RutaModel
    {
        public int RutaId { get; set; }
        public string Nombre { get; set; }
        public int DestinoId { get; set; }
        public bool? Transbordo { get; set; }
    }
}
