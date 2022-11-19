using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
    public class clsLogin : clsConexionSimple
    {
        
        static string cadenaconexion = "Server= localhost\\SQLEXPRESS; DataBase=LoguinIntegrador;Integrated Security=true";
        SqlConnection conexion = new SqlConnection(cadenaconexion);
        public int ConsultaLogin(string usuario, string contraseña)
        {
            int count;
            conexion.Open();
            string consulta = "Select count(*) From ingreso where Usuario ='" + usuario + "'and pass ='" + contraseña + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            count = Convert.ToInt32(comando.ExecuteScalar());
            conexion.Close();
            return count;
        }
    }
}
