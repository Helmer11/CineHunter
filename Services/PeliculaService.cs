using CineHunter.Interfaces;
using CineHunter.Models;
using System;
using System.Collections.Generic;
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
        public IEnumerable<IPeliculas> getListaPelicula()
        {
         
         throw new NotImplementedException();
        }

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
        public bool setDeletePelicula(int IDPelicula)
        {
            try
            {
                using (var conn = conec.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_Agregar_Peliculas", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Pelicula_id", IDPelicula);
                    var result = cmd.ExecuteNonQuery();
                    conec.CerrarConexion();
                    return result > 1;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

       
    }
}
