using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLogic;
using System.Web.Security;

namespace ProyectoFinalBD
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			
        }

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			if (Verificar()){
				FormsAuthentication.SetAuthCookie(txtCorreo.Text, recordarme.Checked);
				Response.Redirect("NuestraEmpresa.aspx");
			}else {
				mensaje.ForeColor = System.Drawing.Color.Red;
				mensaje.Text = "Correo o contraseña inválido";
			}
		}

		private bool Verificar() {
			var login = DLLogin.Login(txtCorreo.Text, txtPassword.Text);
			return login;
		}
	}
}