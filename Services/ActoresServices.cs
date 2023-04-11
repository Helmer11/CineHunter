using CineHunter.Interfaces;
using CineHunter.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CineHunter.Services
{
    internal class ActoresServices : IActores
    {
        private readonly Conexion conec;
        public ActoresServices()
        {
            conec = new Conexion();
        }

        public DataTable getActores()
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_Cargar_Actores", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    conec.CerrarConexion();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string setAgregarActores(Actores act)
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_Agregar_Actores", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre_Completo", act.Nombre_Completo);
                    cmd.Parameters.AddWithValue("@Fecha_Nacimiento", act.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@Sexo", act.Sexo);
                    cmd.Parameters.AddWithValue("@Foto", act.Foto);
                    cmd.ExecuteNonQuery();
                    conec.CerrarConexion();
                    return "Se registro correctamente el Actor";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string setEditaActores(Actores act)
        {
            throw new NotImplementedException();
        }

        public string setEliminacionActores(int id)
        {
            throw new NotImplementedException();
        }
    }
}
