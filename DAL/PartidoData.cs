using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;

namespace DAL
{
    public class PartidoData
    {

        private TipoDeportesData tipoDeporteData = new TipoDeportesData();

        public void GuardarPartido(Partido partido)
        {
            // connecion str
            string connectionString = ConfigurationManager.ConnectionStrings["Parcial1"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO PARTIDO (ID_DEPORTE, EQUIPO_LOCAL, EQUIPO_VISITANTE, FECHA_REGISTRO, FECHA_PARTIDO, MARCADOR_LOCAL, MARCADOR_VISITANTE) VALUES (@id_deporte, @equipo_local, @equipo_visitante, @fecha_registro, @fecha_partido, @marcador_local, @marcador_visitante)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id_deporte", partido.Deporte.IdDeporte); // apuntamos al id del Objeto deporte dentro de partido
                        command.Parameters.AddWithValue("@equipo_local", partido.EquipoLocal);
                        command.Parameters.AddWithValue("@equipo_visitante", partido.EquipoVisitante);
                        command.Parameters.AddWithValue("@fecha_registro", partido.FechaRegistro);
                        command.Parameters.AddWithValue("@fecha_partido", partido.FechaPartido);
                        command.Parameters.AddWithValue("@marcador_local", partido.MarcadorLocal);
                        command.Parameters.AddWithValue("@marcador_visitante", partido.MarcadorVisitante);

                        // ejecutamos cmd
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Partido> getAll()
        {
            try
            {
                List<Partido> listaPartidos = new List<Partido>();

                // connecion str
                string connectionString = ConfigurationManager.ConnectionStrings["Parcial1"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT ID_PARTIDO, ID_DEPORTE, EQUIPO_LOCAL, EQUIPO_VISITANTE, FECHA_REGISTRO, FECHA_PARTIDO,MARCADOR_LOCAL, MARCADOR_VISITANTE FROM PARTIDO;";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Deporte deporte = tipoDeporteData.GetById(Convert.ToInt32(reader["ID_DEPORTE"].ToString()));

                                Partido partido = PartidoMapper.Map(reader, deporte);

                                listaPartidos.Add(partido);
                            }
                        }
                    }
                    return listaPartidos;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarPartido(int idPartido)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Parcial1"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM PARTIDO WHERE ID_PARTIDO = @IdPartido";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@IdPartido", idPartido);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarMarcador(int idPartido, int marcadorLocal, int marcadorVisitante)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Parcial1"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE PARTIDO SET MARCADOR_LOCAL = @MarcadorLocal, " +
                                   "MARCADOR_VISITANTE = @MarcadorVisitante WHERE ID_PARTIDO = @IdPartido";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@MarcadorLocal", marcadorLocal);
                        command.Parameters.AddWithValue("@MarcadorVisitante", marcadorVisitante);
                        command.Parameters.AddWithValue("@IdPartido", idPartido);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}


   
