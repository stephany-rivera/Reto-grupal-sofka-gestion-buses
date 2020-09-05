using Reto.Infraestructure;

namespace Reto.Services.Models
{
    public class PasajeroModel
    {
        public int PasajeroId { get; set; }
        public string NombreCompleto { get; set; }
        public bool Tapabocas { get; set; }
        public int? RutaBusId { get; set; }
        public int? SillaAsignada { get; set; }
        // parametro complementario
        public string PasajeroDestino { get; set; }
        public string PasajeroOrigen { get; set; }
}
}
