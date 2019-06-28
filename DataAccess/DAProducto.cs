using DataEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccess
{
    public class DAProducto
    {
        public static List<Producto> FillDDProductos()
        {
            List<Producto> productos = new List<Producto>();
            ModelTiendaTecno db = new ModelTiendaTecno();
            try
            {
                productos = db.Producto.OrderBy(b => b.idProducto).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            return productos;
        }

        public static bool Agregar(Producto product)
        {
            bool exito = false;
            try
            {
                using (var db = new ModelTiendaTecno())
                {
                    db.Producto.Add(product);
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

        public static Producto GetProducto(int id)
        {
            Producto producto = null;
            ModelTiendaTecno db = new ModelTiendaTecno();
            try
            {
                producto = db.Producto.First(i => i.idProducto == id);
            }
            catch (Exception e)
            {
                throw e;
            }
            return producto;
        }

        public static bool Update(Producto producto)
        {
            bool exito = false;
            try
            {
                using (var db = new ModelTiendaTecno())
                {
                    SqlParameter[] parametros = {
                        new SqlParameter("@e",producto.idProducto), new SqlParameter("@c",producto.idBodega),
                        new SqlParameter("@p",producto.nombre), new SqlParameter("@s",producto.marca),
                        new SqlParameter("@i",producto.modelo),new SqlParameter("@a",producto.codigoBarra),
                        new SqlParameter("@b",producto.descripcion), new SqlParameter("@v",producto.existencia),
                        new SqlParameter("@d",producto.preciocompra),new SqlParameter("@f",producto.porcIV), new SqlParameter("@g", producto.porcIVA),
                        new SqlParameter("@h", producto.estado), new SqlParameter("@j", producto.precioventa), new SqlParameter("@k", producto.excento)
                    };
                    db.Database.ExecuteSqlCommand("update Producto set idBodega=@c,nombre=@p,marca=@s,modelo=@i," +
                        "codigoBarra=@a,descripcion=@b,existencia=@v,preciocompra=@d,porcIV=@f,porcIVA=@g,estado=@h,precioventa=@j,excento=@k where idProducto=@e",
                    parametros[0], parametros[1], parametros[2], parametros[3], parametros[4], parametros[5], 
                    parametros[6], parametros[7], parametros[8], parametros[9], parametros[10], parametros[11], parametros[12], parametros[13]);
                    // db.SaveChanges();
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

        public static bool Delete(int id)
        {
            bool exito = false;
            try
            {
                using (var db = new ModelTiendaTecno())
                {
                    db.Database.ExecuteSqlCommand("delete from Producto where idProducto=@id", new SqlParameter("@id", id));
                    db.Producto.Remove(db.Producto.First(i => i.idProducto == id));
                    db.SaveChanges();
                exito = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return exito;
        }

 
    }

}
