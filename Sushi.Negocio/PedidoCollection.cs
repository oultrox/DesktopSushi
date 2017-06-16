
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sushi.Negocio;
namespace Sushi.Negocio
{

    [DataObject]
    public class PedidoCollection
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<DALC.PEDIDO> GetPedidos()
        {
            return CommonBC.ModeloSushi.PEDIDO.ToList();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<DALC.PEDIDO> GetPedidosPorTipo(string estado)
        {
            return CommonBC.ModeloSushi.PEDIDO.Where
                (b => b.ESTADO == estado).ToList();
        }
    }
}
