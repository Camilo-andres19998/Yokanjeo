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
    
    public partial class Tbl_CompraDetalle
    {
        public int CompraDetalleId { get; set; }
        public Nullable<int> MiembroId { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public Nullable<int> CompraId { get; set; }
        public Nullable<decimal> Pagado { get; set; }
        public string TipoPago { get; set; }
    
        public virtual Tbl_Miembros Tbl_Miembros { get; set; }
    }
}