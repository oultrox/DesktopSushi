//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sushi.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.DIRECCION = new HashSet<DIRECCION>();
            this.PEDIDO = new HashSet<PEDIDO>();
        }
    
        public decimal IDUSUARIO { get; set; }
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOPATERNO { get; set; }
        public string PASS { get; set; }
        public string EMAIL { get; set; }
        public string ACTIVADO { get; set; }
        public decimal NIVELUSUARIO_IDNIVELUSUARIO { get; set; }
    
        public virtual ICollection<DIRECCION> DIRECCION { get; set; }
        public virtual NIVELUSUARIO NIVELUSUARIO { get; set; }
        public virtual ICollection<PEDIDO> PEDIDO { get; set; }
    }
}
