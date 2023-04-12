using CineHunter.Interfaces;
using CineHunter.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHunter.Services
{
    internal class PeliculaService : IPeliculas
    {
        Conexion conec;
        
        public PeliculaService()
        {
            conec = new Conexion();
        }
        /// <summary>
        /// Metoso que carga el listado de pelicula
        /// </summary>
        /// <returns>Devuelve un datatable con los objeto del listado</returns>
        /// <exception cref="Exception">Se lanza cuando falla al momento de realizar el proceso</exception>
        public DataTable getListaPelicula(string titulo = "")
        {

            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_Cargar_Pelicula", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Titulo", titulo);
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
        /// Metodo que cargar el detalle de las peliculas
        /// </summary>
        /// <param name="Detalle_id">parametro que obtiene el id de la pelicula </param>
        /// <returns>Devuelve un datatable con los objeto del listado</returns>
        /// <exception cref="Exception">Se lanza cuando falla al momento de realizar el proceso</exception>
        public DataTable getDetallePelicula(int Detalle_id)
        {

            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("sp_Detalle_Pelicula", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Pelicula_id", Detalle_id);
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
        /// Metodo que registra la pelicula en la base de datos 
        /// </summary>
        /// <param name="peli">Objeto obtenie los valores de la pelicula</param>
        /// <returns>Retorna un string cuando se agrega en la base de dato, de lo contrario se lanza una excepcion</returns>
        /// <exception cref="Exception">Se lanza cuando falla al momento de realizar el proceso</exception>
        public string setAgregarPelicula(Peliculas peli)
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_Agregar_Peliculas", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Titulo", peli.Titulo);
                    cmd.Parameters.AddWithValue("@Descripcion", peli.Descripcion);
                    cmd.Parameters.AddWithValue("@Anio", peli.Anio);
                    cmd.Parameters.AddWithValue("@Fecha_Estreno", peli.Fecha_Estreno);
                    cmd.Parameters.AddWithValue("@ImagenPelicula", peli.ImagenPelicula);
                    cmd.Parameters.AddWithValue("@ActorID", peli.ActorID);
                    cmd.Parameters.AddWithValue("@GeneroID", peli.GeneroID);
                     cmd.ExecuteNonQuery();
                    conec.CerrarConexion();
                    return "Se registro correctamente la pelicula";
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="peli"></param>
        /// <returns>Retorna un string cuando se agrega en la base de datos, de lo contrario se lanza una excepcion</returns>
        /// <exception cref="Exception">Se lanza cuando falla al momento de realizar el proceso</exception>
        public string setEditaPelicula(Peliculas peli)
        {

            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_Agregar_Peliculas", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Titulo", peli.Titulo);
                    cmd.Parameters.AddWithValue("@Descripcion", peli.Descripcion);
                    cmd.Parameters.AddWithValue("@Anio", peli.Anio);
                    cmd.Parameters.AddWithValue("@Fecha_Estreno", peli.Fecha_Estreno);
                    cmd.Parameters.AddWithValue("@ImagenPelicula", peli.ImagenPelicula);
                    cmd.Parameters.AddWithValue("@ActorID", peli.ActorID);
                    cmd.Parameters.AddWithValue("@GeneroID", peli.GeneroID);

                    cmd.ExecuteNonQuery();
                    conec.CerrarConexion();
                    return "Se Actualizo correctamente la pelicula";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Metodo que se encarga de inactivar el registro la pelicula
        /// </summary>
        /// <param name="IDPelicula">parametro para consultar el id de la pelicula y porder inactivarlo</param>
        /// <returns>Retorna un booleano </returns>
        public bool setDeletePelicula(int IDPelicula)
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_Inactivar_Peliculas", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Pelicula_id", IDPelicula);
                    var result = cmd.ExecuteNonQuery();
                    conec.CerrarConexion();
                    return result  == 1;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

       
    }
}
