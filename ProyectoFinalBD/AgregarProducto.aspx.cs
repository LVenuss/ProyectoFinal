using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalBD
{
    public partial class AgregarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDDProductos();
            }
        }

        private void FillDDProductos()
        {
            gvProducto.DataSource = DLProducto.GetProductos();
            gvProducto.DataBind();
        }

       

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            msjPrincipal.Text = "Error al agregar";
            msjPrincipal.ForeColor = System.Drawing.Color.Red;
            //int i = 0;
            double x = 0.0;
            float j = 000000;
            if (String.IsNullOrEmpty(txtID.Text))
            {
                msjID.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(txtBodega.Text))
            {
                msjIDBo.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(txtNombre.Text))
            {
                msjNombre.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(txtMarca.Text))
            {
                msjMarca.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(txtModelo.Text))
            {
                msjModelo.Text = "Este campo es obligatorio";
            }
            else if (string.IsNullOrEmpty(txtCodigoBarra.Text))
            {
                msjCBarra.Text = "El campo debe tener un numero";
            }
            else if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MsjDescripcion.Text = "El campo es obligatorio";
            }
            else if (!double.TryParse(txtExistencia.Text, out x))
            {
                MsjExistencia.Text = "El campo debe tener un numero";
            }
            else if (!float.TryParse(Precio.Text, out j))
            {
                MsjPrecio.Text = "El campo debe tener un numero";
            }
            else if (!float.TryParse(txtPorcIV.Text, out j))
            {
                MsjPorcIV.Text = "El campo debe tener un numero";
            }
            else
            {
                DataEntity.Producto producto = new DataEntity.Producto();
                producto.idProducto = Convert.ToInt32(txtID.Text);
                producto.idBodega = Convert.ToInt32(txtBodega.Text);
                producto.nombre = txtNombre.Text;
                producto.marca = txtMarca.Text;
                producto.modelo = txtModelo.Text;
                producto.codigoBarra = Convert.ToInt32(txtCodigoBarra.Text);
                producto.descripcion = txtDescripcion.Text;
                producto.existencia = Convert.ToInt32(txtExistencia.Text);
                producto.preciocompra = Convert.ToInt32(Precio.Text);
                producto.porcIV = Convert.ToInt32(txtPorcIV.Text);
                producto.porcIVA = Convert.ToInt32(txtPorcIVA.Text);
                var es = estado.Checked ? "a" : "i";
                producto.estado = es;
                producto.precioventa = Convert.ToInt32(txtPrecioVenta.Text);
                var ex = exento.Checked ? "s" : "n";
                producto.excento = ex;

                if (DLProducto.Agregar(producto))
                {
                    Response.Redirect("AgregarProducto.aspx");
                }
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            msjPrincipal.Text = "Error al agregar";
            msjPrincipal.ForeColor = System.Drawing.Color.Red;
            //int i = 0;
            double x = 0.0;
            float j = 000000;
            if (String.IsNullOrEmpty(txtID.Text))
            {
                msjID.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(txtBodega.Text))
            {
                msjIDBo.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(txtNombre.Text))
            {
                msjNombre.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(txtMarca.Text))
            {
                msjMarca.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(txtModelo.Text))
            {
                msjModelo.Text = "Este campo es obligatorio";
            }
            else if (string.IsNullOrEmpty(txtCodigoBarra.Text))
            {
                msjCBarra.Text = "El campo debe tener un numero";
            }
            else if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MsjDescripcion.Text = "El campo es obligatorio";
            }
            else if (!double.TryParse(txtExistencia.Text, out x))
            {
                MsjExistencia.Text = "El campo debe tener un numero";
            }
            else if (!float.TryParse(Precio.Text, out j))
            {
                MsjPrecio.Text = "El campo debe tener un numero";
            }
            else if (!float.TryParse(txtPorcIV.Text, out j))
            {
                MsjPorcIV.Text = "El campo debe tener un numero";
            }
            else
            {
                DataEntity.Producto producto = new DataEntity.Producto();
                producto.idProducto = Convert.ToInt32(txtID.Text);
                producto.idBodega = Convert.ToInt32(txtBodega.Text);
                producto.nombre = txtNombre.Text;
                producto.marca = txtMarca.Text;
                producto.modelo = txtModelo.Text;
                producto.codigoBarra = Convert.ToInt32(txtCodigoBarra.Text);
                producto.descripcion = txtDescripcion.Text;
                producto.existencia = Convert.ToInt32(txtExistencia.Text);
                producto.preciocompra = Convert.ToInt32(Precio.Text);
                producto.porcIV = Convert.ToInt32(txtPorcIV.Text);
                producto.porcIVA = Convert.ToInt32(txtPorcIVA.Text);
                var es=estado.Checked? "a" : "i";
                producto.estado = es;
                producto.precioventa = Convert.ToInt32(txtPrecioVenta.Text);
                var ex= exento.Checked? "s" : "n";
                producto.excento = ex; 

                if (DLProducto.Update(producto))
                {
                    Response.Redirect("AgregarProducto.aspx");
                }
            }

        }

        protected void gvProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gridViewRow = gvProducto.SelectedRow;
            txtID.Text = gridViewRow.Cells[0].Text;
            txtID.Enabled = false;
            txtBodega.Text = gridViewRow.Cells[1].Text;
            txtNombre.Text = gridViewRow.Cells[2].Text;
            txtMarca.Text = gridViewRow.Cells[3].Text;
            txtModelo.Text = gridViewRow.Cells[4].Text;
            txtCodigoBarra.Text = gridViewRow.Cells[5].Text;
            txtDescripcion.Text = gridViewRow.Cells[6].Text;
            txtExistencia.Text = gridViewRow.Cells[7].Text;
            Precio.Text = gridViewRow.Cells[8].Text;
            txtPorcIV.Text = gridViewRow.Cells[9].Text;
        }

        protected void gvProducto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int indice = e.RowIndex;
            int id = Convert.ToInt32(gvProducto.Rows[indice].Cells[1].Text);
            if (DLProducto.Delete(id))
            {
                Response.Redirect("AgregarProducto.aspx");
            }
        
        }
    }
}