using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;

namespace Capa_Negocio
{
    public class clsLogin
    {
        Capa_Datos.clsLogin login = new Capa_Datos.clsLogin();
        public int loginUsuario(string USUARIO,string PASS) {

            return login.ConsultaLogin(USUARIO, PASS);
        
        }//ultimo

        
    }
}
