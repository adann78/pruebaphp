//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webMitienda.contexto
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_productos
    {
        public int id_producto { get; set; }
        public string producto_nombre { get; set; }
        public long producto_precio { get; set; }
        public int producto_cantidad { get; set; }
        public string producto_descripcion { get; set; }
        public int id_proveedor { get; set; }
    
        public virtual tb_proveedores tb_proveedores { get; set; }
    }
}
