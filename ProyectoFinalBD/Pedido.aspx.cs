using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalBD
{
    public partial class Pedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                FillDDPedido();
                llenarddProveedor();
                llenarddProductos();

            }
        }

        private void FillDDPedido()
        {
            gvPedido.DataSource = DLPedido.FillDDPedido();
            gvPedido.DataBind();
            tbID.Enabled = true;
        }

        protected void gvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gridViewRow = gvPedido.SelectedRow;
            tbID.Text = gridViewRow.Cells[0].Text;
            tbID.Enabled = false;
           ddProveedor.SelectedValue = gridViewRow.Cells[1].Text;
            tbUsuario.Text = gridViewRow.Cells[2].Text;
            tbCantidad.Text = gridViewRow.Cells[3].Text;
            tbTotal.Text = gridViewRow.Cells[4].Text;

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

            int i = 0;
            if (String.IsNullOrEmpty(tbID.Text))
            {
                msjID.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(ddProveedor.Text))
            {
                msjProveedor.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(tbUsuario.Text))
            {
                msjUser.Text = "Este campo es obligatorio";
            }
            else if (!int.TryParse(tbCantidad.Text, out i))
            {
                msjCant.Text = "El campo debe tener un numero";
            }
            else if (!int.TryParse(tbTotal.Text, out i))
            {
                msjTotal.Text = "El campo debe tener un numero";
            }
            else
            {
                DataEntity.Pedido pedido = new DataEntity.Pedido();
                pedido.idPedido = Convert.ToInt32(tbID.Text);
                pedido.idProveedor = Convert.ToInt32(ddProveedor.SelectedValue.ToString());
                pedido.idUsuario = Convert.ToInt32(tbUsuario.Text);
                pedido.cantidad = Convert.ToInt32(tbCantidad.Text);
                pedido.total = Convert.ToInt32(tbTotal.Text);
                if (DLPedido.Update(pedido))
                {
                    Response.Redirect("Pedido.aspx");
                }
            }
        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {

            int i = 0;
            if (String.IsNullOrEmpty(tbID.Text))
            {
                msjID.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(ddProveedor.Text))
            {
                msjProveedor.Text = "Este campo es obligatorio";
            }
            else if (String.IsNullOrEmpty(tbUsuario.Text))
            {
                msjUser.Text = "Este campo es obligatorio";
            }
            else if (!int.TryParse(tbCantidad.Text, out i))
            {
                msjCant.Text = "El campo debe tener un numero";
            }
            else if (!int.TryParse(tbTotal.Text, out i))
            {
                msjTotal.Text = "El campo debe tener un numero";
            }
            else
            {
                DataEntity.Pedido pedido = new DataEntity.Pedido();
                pedido.idPedido = Convert.ToInt32(tbID.Text);
                pedido.idProveedor = Convert.ToInt32(ddProveedor.SelectedValue.ToString());
                pedido.idUsuario = Convert.ToInt32(tbUsuario.Text);
                pedido.cantidad= Convert.ToInt32(tbCantidad.Text);
                pedido.total= Convert.ToInt32(tbTotal.Text);

                DataEntity.ProductoPedido pro = new DataEntity.ProductoPedido();
                pro.idPedido=Convert.ToInt32(tbID.Text);
                pro.idProducto= Convert.ToInt32(ddProducto.SelectedValue.ToString());
                pro.fecha = Convert.ToDateTime(txtFecha.Text);

                if (DLPedido.Create(pedido) && DLPedido.CreatePedidoP(pro))
                {
                    Response.Redirect("Pedido.aspx");
                }
            }
        }
        public void llenarddProveedor()
        {
            ddProveedor.DataSource = DLPedido.proveedor();
            ddProveedor.DataValueField = "idProveedor";
            ddProveedor.DataTextField = "nombre";
            ddProveedor.DataBind();
        }

        public void llenarddProductos()
        {
            ddProducto.DataSource = DLPedido.getAllProductos();
            ddProducto.DataValueField = "idProducto";
            ddProducto.DataTextField = "modelo";
            ddProducto.DataBind();
        }

    }

}