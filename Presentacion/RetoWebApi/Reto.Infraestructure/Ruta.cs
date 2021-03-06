//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reto.Infraestructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ruta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ruta()
        {
            this.RutaBus = new HashSet<RutaBus>();
        }
    
        public int RutaId { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> OrigenId { get; set; }
        public int DestinoId { get; set; }
        public Nullable<bool> Trasbordo { get; set; }
        public Nullable<int> TrasbordoMunicipioId { get; set; }
    
        public virtual Municipio Municipio { get; set; }
        public virtual Municipio Municipio1 { get; set; }
        public virtual Municipio Municipio2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RutaBus> RutaBus { get; set; }
    }
}
