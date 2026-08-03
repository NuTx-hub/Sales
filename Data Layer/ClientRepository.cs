using Entity_Layer;
using Microsoft.Data.SqlClient;

namespace Data_Layer
{
    public class ClientRepository
    {
        string connectionString = "Server=ELIZABETH\\MSSQLSERVER2026; Database=SalesDB; TrustServerCertificate = True; Trusted_Connection = True;";

        public bool insertClient(Client client)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();
                string query = "INSERT INTO Client(Id, Ci, Name, Lastname, Email) VALUES(@Id, @Ci, @Name, @Lastname, @Email)";
                using SqlCommand cmd = new(query, conn);
                {
                    cmd.Parameters.AddWithValue("@Id", client.IdClient);
                    cmd.Parameters.AddWithValue("@Ci", client.Ci);
                    cmd.Parameters.AddWithValue("@Name", client.Name);
                    cmd.Parameters.AddWithValue("@Lastname", client.LastName);
                    cmd.Parameters.AddWithValue("@Email", client.Email);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                
            }
            catch (SqlException sqlException)
            {
                throw new Exception("A database error has occurred while inserting the client.", sqlException);
            }
            catch (Exception exception)
            {
                throw new Exception("An error has occurred while inserting the client.", exception);
            }
        }

    }
}
