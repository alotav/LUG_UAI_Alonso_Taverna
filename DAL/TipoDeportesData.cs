using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TipoDeportesData
    {

        public List<Deporte> getAll()
        {
            try
            {
                List<Deporte> deportes = new List<Deporte>();
                // connecion str
                string connectionString = ConfigurationManager.ConnectionStrings["Parcial1"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // abrimos con y pasamos query
                    connection.Open();
                    string query = "SELECT ID_DEPORTE, DESCRIPCION FROM DEPORTE";

                    using (SqlCommand sqlcommand = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = sqlcommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // lo agregamos a la lista desde mapper
                                deportes.Add(DeporteMapper.Map(reader));
                            }
                        }

                    }
                }
                return deportes;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Deporte GetById(int idTipoDeporte) 
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Parcial1"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM DEPORTE WHERE ID_DEPORTE = @ID;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", idTipoDeporte);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return DeporteMapper.Map(reader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}