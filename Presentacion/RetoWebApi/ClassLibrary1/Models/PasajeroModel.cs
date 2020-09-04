using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Services.Models
{
    public class PasajeroModel
    {
        public int PasajeroId { get; set; }
        public string NombreCompleto { get; set; }
        public bool Tapabocas { get; set; }
        public int? RutaBusId { get; set; }
        public int? SillaAsignada { get; set; }
    }
}
