//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yokanjeo.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Miembros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Miembros()
        {
            this.Tbl_CompraDetalle = new HashSet<Tbl_CompraDetalle>();
        }
    
        public int MiembroId { get; set; }
        public string PrimerNombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoId { get; set; }
        public string Contrasena { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<bool> Eliminar { get; set; }
        public Nullable<System.DateTime> Crear { get; set; }
        public Nullable<System.DateTime> Modificar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_CompraDetalle> Tbl_CompraDetalle { get; set; }
    }
}
