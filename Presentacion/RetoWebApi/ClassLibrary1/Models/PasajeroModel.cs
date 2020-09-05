using Reto.Infraestructure;
using System.ComponentModel.DataAnnotations;

namespace Reto.Services.Models
{
    public class PasajeroModel
    {
        public int PasajeroId { get; set; }
        [Required]
        public string NombreCompleto { get; set; }
        [Required]
        public bool Tapabocas { get; set; }
        public int? RutaBusId { get; set; }
        public int? SillaAsignada { get; set; }
        // parametro complementario
        [Required]
        public string PasajeroDestino { get; set; }
        [Required]
        public string PasajeroOrigen { get; set; }
}
}
