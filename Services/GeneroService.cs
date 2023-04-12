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


        /// <summary>
        /// Metodo que carga los generos de las peliculas
        /// </summary>
        /// <returns>Retorna un datatable  con los campos id y descripcion </returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Metodo que guarda el registro del genero
        /// </summary>
        /// <param name="gene">Objeto obtenie los valores del genero</param>
        /// <returns>Retorna un string cuando se agrega en la base de dato, de lo contrario se lanza una excepcion</returns>
        /// <exception cref="Exception">Se lanza cuando falla al momento de realizar el proceso</exception>
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

        /// <summary>
        /// Metodo que realiza la actualizacion del genero
        /// </summary>
        /// <param name="gene">Objeto que guarda los datos para actualizar el generos</param>
        /// <returns>Retorna un string cuando se agrega en la base de dato, de lo contrario se lanza una excepcion</returns>
        /// <exception cref="Exception">Se lanza cuando falla al momento de realizar el proceso</exception>
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


        /// <summary>
        /// Metodo que se encarga de inactivar el registro del genero
        /// </summary>
        /// <param name="IDGenero">paramentro para buscar el genero e inactivarlo</param>
        /// <returns>Retorna un string cuando se agrega en la base de dato, de lo contrario se lanza una excepcion</returns>
        /// <exception cref="Exception">Se lanza cuando falla al momento de realizar el proceso</exception>
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
