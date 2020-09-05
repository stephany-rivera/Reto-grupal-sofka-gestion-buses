using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reto.Services.Models
{
    public class RutaModel
    {
        public int RutaId { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int DestinoId { get; set; }
        public bool? Transbordo { get; set; }
    }
}
