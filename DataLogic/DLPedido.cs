using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class DLPedido
    {
        public static List<Pedido> FillDDPedido()
        {
            return DAPedido.FillDDPedido();

        }

        public static bool Update(Pedido pedido)
        {
            return DAPedido.Update(pedido);
        }
        public static bool Create(Pedido pedido)
        {
            return DAPedido.Create(pedido);
        }
        public static List<Proveedor> proveedor()
        {
            return DAPedido.getAllProveedor();
        }
        public static List<Producto> getAllProductos()
        {
            return DAPedido.getAllProductos();
        }

        public static bool CreatePedidoP(ProductoPedido pedido)
        {
            return DAPedido.CreatePedidoP(pedido);
        }
    }
}
