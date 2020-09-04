using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Models
{
    public class BusModel
    {
        public int BusId { get; set; }
        public int? Capacidad { get; set; }
        public bool? Trasbordo { get; set; }
    }
}
