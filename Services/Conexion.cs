using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CineHunter.Services
{
    internal class Conexion
    {
 
        private static readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionCine"].ConnectionString;
        private SqlConnection conec = null;

        public SqlConnection AbrirConexion()
        {
            conec = new SqlConnection(cadenaConexion);
            if (conec.State == ConnectionState.Closed)
                conec.Open();
            return conec;
        }


        public SqlConnection CerrarConexion()
        {
            if (conec.State == ConnectionState.Open)
                conec.Close();
            return conec;
        }



    }
}
