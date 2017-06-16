using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.Negocio
{
    public class PEDIDO
    {
        public int idPedido;
        public int valor;
        public DateTime fecha;
        public string estado;
        public string detalle;
        public int usuario_id_usuario;
        public int direccion_id_direccion;

        public PEDIDO()
        {
            this.Init();
        }
        private void Init()
        {

            idPedido = 0;
            detalle = string.Empty;
            fecha = DateTime.Today;
            valor = 0;
            estado = string.Empty;
            usuario_id_usuario = 0;
            direccion_id_direccion = 0;

        }

        //Metodos CRUD
        public bool Read()
        {
            try
            {
                DALC.PEDIDO ped = CommonBC.ModeloSushi.PEDIDO.First(pedid => pedid.IDPEDIDO == idPedido);
                idPedido = (int)ped.IDPEDIDO;
                detalle = ped.DETALLE;
                fecha = ped.FECHA;
                this.valor = (int)ped.VALOR;
                estado = ped.ESTADO;
                usuario_id_usuario = (int)ped.USUARIO_IDUSUARIO;
                direccion_id_direccion = (int)ped.DIRECCION_IDDIRECCION;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create()
        {
            try
            {
                DALC.PEDIDO p = new DALC.PEDIDO();
                p.IDPEDIDO = idPedido;
                p.DETALLE = detalle;
                p.FECHA = fecha;
                p.VALOR = valor;
                p.ESTADO = estado;
                p.USUARIO_IDUSUARIO = usuario_id_usuario;
                p.DIRECCION_IDDIRECCION = direccion_id_direccion;

                CommonBC.ModeloSushi.PEDIDO.Add(p);
                CommonBC.ModeloSushi.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                DALC.PEDIDO p = CommonBC.ModeloSushi.PEDIDO.First(x => x.IDPEDIDO == idPedido);
                p.IDPEDIDO = idPedido;
                p.DETALLE = detalle;
                p.FECHA = fecha;
                p.VALOR = valor;
                p.ESTADO = estado;
                p.USUARIO_IDUSUARIO = usuario_id_usuario;
                p.DIRECCION_IDDIRECCION = direccion_id_direccion;

                CommonBC.ModeloSushi.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                DALC.PEDIDO prod = CommonBC.ModeloSushi.PEDIDO.First(p => p.IDPEDIDO == idPedido);

                CommonBC.ModeloSushi.PEDIDO.Remove(prod);
                CommonBC.ModeloSushi.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
