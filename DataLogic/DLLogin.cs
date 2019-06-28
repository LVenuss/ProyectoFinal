using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataLogic
{
	public class DLLogin
	{
		public static bool Login(string correo, string password) {
			return DALogin.Login(correo,password);
		}
	}
}
