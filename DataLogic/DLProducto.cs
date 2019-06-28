using DataAccess;
using DataEntity;
using System.Collections.Generic;

namespace DataLogic
{
    public class DLProducto
    {
        public static List<Producto> GetProductos()
        {
            return DAProducto.FillDDProductos();
        }

        public static bool Agregar(Producto producto)
        {
            return DAProducto.Agregar(producto);
        }

        public static Producto GetProducto(int id)
        {
            return DAProducto.GetProducto(id);
        }
        public static bool Update(Producto producto)
        {
            return DAProducto.Update(producto);
        }

        public static bool Delete( int id)
        {
            return DAProducto.Delete(id);
        }
    }
}
