using DataEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAPedido
    {
        public static List<Pedido> FillDDPedido()
        {
            List<Pedido> pedido = new List<Pedido>();
            ModelTiendaTecno db = new ModelTiendaTecno();
            try
            {
                pedido = db.Pedido.OrderBy(b => b.idPedido).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            return pedido;
        }
    
        public static List<Proveedor> getAllProveedor()
        {
            List<Proveedor> proveedor = new List<Proveedor>();
            ModelTiendaTecno db = new ModelTiendaTecno();
            try
            {
                proveedor = db.Proveedor.OrderBy(b => b.idProveedor).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            return proveedor;
        }
        public static List<Producto> getAllProductos()
        {
            List<Producto> pro = new List<Producto>();
            ModelTiendaTecno db = new ModelTiendaTecno();
            try
            {
                pro = db.Producto.OrderBy(b => b.idProducto).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            return pro;
        }
        public static bool Create(Pedido pedido)
        {
            bool exito = false;
            try
            {
                using (var db = new ModelTiendaTecno())
                {
                    db.Pedido.Add(pedido);
                    db.SaveChanges();
                    exito = true;
                }
            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }

        public static bool CreatePedidoP(ProductoPedido pedido)
        {
            bool exito = false;
            try
            {
                using (var db = new ModelTiendaTecno())
                {
                    db.ProductoPedido.Add(pedido);
                    db.SaveChanges();
                    exito = true;
                }
            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }
        public static bool Update(Pedido pedido)
        {
            bool exito = false;
            try
            {
                using (var db = new ModelTiendaTecno())
                {
                    SqlParameter[] parametros = {
                        new SqlParameter("@e",pedido.idProveedor), new SqlParameter("@c",pedido.idUsuario),
                        new SqlParameter("@p",pedido.cantidad), new SqlParameter("@s",pedido.total),
                        new SqlParameter("@i",pedido.idPedido)
                    };
                    db.Database.ExecuteSqlCommand("update Pedido set idProveedor=@e,idUsuario=@c,cantidad=@p,total=@s where idPedido=@i",
                    parametros[0], parametros[1], parametros[2], parametros[3], parametros[4]);
                    //db.SaveChanges();
                    exito = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            return exito;
        }

       
     }

}
