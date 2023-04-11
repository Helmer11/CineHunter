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
    internal class GeneroService : IGenero
    {
        Conexion conec;

        public GeneroService()
        {
            conec = new Conexion();
        }
        public DataTable GetGeneros()
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_Cargar_Genero", conn);
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

        public string setAgregarGenero(Generos gene)
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_Agregar_Genero", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Descripcion", gene.Descriopcion);
                    cmd.ExecuteNonQuery();
                    conec.CerrarConexion();
                    return "Se registro correctamente el genero";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string setEditaGenero(Generos gene)
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_Agregar_Genero", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Genero_id", gene.Genero_id);
                    cmd.Parameters.AddWithValue("@Descripcion", gene.Descriopcion);
                    cmd.ExecuteNonQuery();
                    conec.CerrarConexion();
                    return "Se Actualizo correctamente el genero";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string setEliminarGenero(int IDGenero)
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_Agregar_Genero", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Genero_id", IDGenero);
                    cmd.ExecuteNonQuery();
                    conec.CerrarConexion();
                    return "Se registro correctamente el genero";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
