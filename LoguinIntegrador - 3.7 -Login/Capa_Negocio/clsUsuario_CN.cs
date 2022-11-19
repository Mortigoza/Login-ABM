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
    public class clsUsuario_CN
    {
        clsUsuarios usuario = new clsUsuarios();
        public DataTable MostrarUsuarios()
        {
           
            DataTable Tabla = new DataTable();
            Tabla = usuario.Mostrar();
            return Tabla;
        }

        public void AgregarUsuario(string nombre, string apellido, string Email, string nombreCalle, string numeroCalle, string DNI)
        {
            usuario.Agregar(nombre,apellido, Email,nombreCalle,numeroCalle,DNI);

        }
        public void Editar(string nombre, string apellido, string Email, string nombreCalle, string numeroCalle, string DNI, string id) {
            usuario.Editar(nombre, apellido, Email, nombreCalle, numeroCalle, DNI, Convert.ToInt32(id));
        
        }

        public void Eliminar(string id)
        {
            usuario.Eliminar(Convert.ToInt32(id));
        }

    }
}
