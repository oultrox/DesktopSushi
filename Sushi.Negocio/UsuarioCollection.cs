using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.Negocio
{
        [DataObject]
        public class UsuarioCollection
        {
            [DataObjectMethod(DataObjectMethodType.Select)]
            public List<DALC.USUARIO> GetUsuarios()
            {
                return CommonBC.ModeloSushi.USUARIO.ToList();
            }

            [DataObjectMethod(DataObjectMethodType.Select)]
            public List<DALC.PEDIDO> GetPedidosPorTipo(string estado)
            {
                return CommonBC.ModeloSushi.PEDIDO.Where
                    (b => b.ESTADO == estado).ToList();
            }
        }
    
}
