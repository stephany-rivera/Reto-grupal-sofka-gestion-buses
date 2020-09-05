using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reto.Services.Models
{
    public class MunicipioModel
    {
        public int MunicipioId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Departamento { get; set; }
    }
}
