using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BOL
{
    public class Usuario
    {
        DBAccess acceso = new DBAccess();

        public DataTable iniciarSesion(string Nombreusuario)
        {
            DataTable dataTable = new DataTable();

            acceso.conectar();
            SqlCommand command = new SqlCommand("spu_usuario_login", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombreusuario", Nombreusuario);

            // El objeto dataTable carga el resultado obtenido por el comando
            dataTable.Load(command.ExecuteReader());

            acceso.desconectar();

            return dataTable;

        }
    }
}
