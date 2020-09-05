using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reto.Services.Models
{
    public class RutaBusModel
    {
        public int RutaBusId { get; set; }
        [Required]
        public int? RutaId { get; set; }
        [Required]
        public int? BusId { get; set; }
    }
}
