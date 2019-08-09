//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Food.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicio()
        {
            this.Detalle_Orden = new HashSet<Detalle_Orden>();
        }
    
        public int idServicio { get; set; }
        public int idTipoAB { get; set; }
        public Nullable<int> idTipoServicio { get; set; }
        public string Nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<double> precio { get; set; }
        public Nullable<int> tiempo { get; set; }
        public string imagen { get; set; }
        public Nullable<bool> inactive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Orden> Detalle_Orden { get; set; }
        public virtual TipoAB TipoAB { get; set; }
        public virtual TipoServicio TipoServicio { get; set; }
    }
}