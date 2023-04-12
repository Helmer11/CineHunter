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
        /// <summary>
        /// Metodo que realiza la carga de los actores 
        /// </summary>
        /// <returns>Retorna un datatable con los campos de la base de datos</returns>
        /// <exception cref="Exception">En caso de no cumplir </exception>
        public DataTable getActores()
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_Cargar_Actores", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
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

        /// <summary>
        /// Metodo para obtener el detalle de la pelicula
        /// </summary>
        /// <param name="id">parametro para consultar el id del Actor y obtener el detalle</param>
        /// <returns></returns>
        /// <exception cref="Exception">Se lanza cuando falla al momento de realizar el proceso</exception>
        public DataTable getDetalleActores(int id)
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                   
                    SqlCommand cmd = new SqlCommand("sp_Detalle_Actor", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Actor_id", id);
                    var dt = new DataTable();
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
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_Edita_Actores", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Actor_id", act.Actor_id);
                    cmd.Parameters.AddWithValue("@Nombre_Completo", act.Nombre_Completo);
                    cmd.Parameters.AddWithValue("@Fecha_Nacimiento", act.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@Sexo", act.Sexo);
                    cmd.Parameters.AddWithValue("@Foto", act.Foto);
                    cmd.ExecuteNonQuery();
                    conec.CerrarConexion();
                    return "Se Actualizo correctamente el Actor";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string setEliminacionActores(int id)
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_Inactivar_Actores", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Actor_id", id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    conec.CerrarConexion();
                    return "Se elimino correctamente el actor";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
