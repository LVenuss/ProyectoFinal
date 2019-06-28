using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataAccess
{
	public class DALogin
	{
		public static bool Login(string correo, string password) {
			var db = new ModelTiendaTecno();
			var user = db.Usuario.FirstOrDefault(u => u.correo == correo && u.clave == password);
			return user != null; 
		}
	}
}
