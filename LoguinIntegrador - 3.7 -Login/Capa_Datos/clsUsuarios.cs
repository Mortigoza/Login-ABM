using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Deployment.Internal;

namespace Capa_Datos
{
    public class clsUsuarios
    {
        private clsConexionSimple conexion = new clsConexionSimple();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "verUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Agregar(string nombre,string apellido, string Email, string nombreCalle,string numeroCalle, string DNI)
        {
           
            comando.Connection= conexion.AbrirConexion();
            comando.CommandText = "insert into DatosUsuario values('"+nombre+"','"+apellido+"','"+Email+"','"+nombreCalle+"','"+numeroCalle+"','"+DNI+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar(string nombre, string apellido, string Email, string nombreCalle, string numeroCalle, string DNI, int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection= conexion.AbrirConexion();
            comando.CommandText = "EditarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("nombre", nombre);
            comando.Parameters.AddWithValue("apellido", apellido);
            comando.Parameters.AddWithValue("@Email", Email);
            comando.Parameters.AddWithValue("@nombreCalle", nombreCalle);
            comando.Parameters.AddWithValue("@nroCalle", numeroCalle);
            comando.Parameters.AddWithValue("@dni", DNI);
            comando.Parameters.AddWithValue("@id", id);



            comando.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            conexion.AbrirConexion();
            comando.CommandText = "eliminarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdDatosUsuario", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
      
      


    }
}
