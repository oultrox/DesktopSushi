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
    
    public partial class DIRECCION
    {
        public DIRECCION()
        {
            this.PEDIDO = new HashSet<PEDIDO>();
        }
    
        public decimal IDDIRECCION { get; set; }
        public string COMUNA { get; set; }
        public string PROVINCIA { get; set; }
        public string REGION { get; set; }
        public string CALLE { get; set; }
        public string NUMERO { get; set; }
        public string DEPTO { get; set; }
        public string DETALLEDIRECCION { get; set; }
        public decimal USUARIO_IDUSUARIO { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PEDIDO> PEDIDO { get; set; }
    }
}
