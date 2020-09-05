using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reto.Services.Models
{
    public class BusModel
    {
        public int BusId { get; set; }
        [Required]
        public int? Capacidad { get; set; }
        public int? CapacidadActual { get; set; }
    }
}
