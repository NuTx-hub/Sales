using Entity_Layer;
using Microsoft.Data.SqlClient;

namespace Data_Layer
{
    public class ClientRepository
    {
        readonly string connectionString = "Server=ELIZABETH\\MSSQLSERVER2026; Database=SalesDB; TrustServerCertificate = True; Trusted_Connection = True;";

        public bool InsertClient(Client client)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();
                string query = "INSERT INTO Client (DNI, Name, Lastname, Email) VALUES(@DNI, @Name, @Lastname, @Email)";
                using SqlCommand cmd = new(query, conn);
                {
                    cmd.Parameters.AddWithValue("@DNI", Convert.ToString(client.DNI));
                    cmd.Parameters.AddWithValue("@Name", client.Name);
                    cmd.Parameters.AddWithValue("@Lastname", client.Lastname);
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

        public bool DeleteClient(int id)
        {
            try
            {
                SqlConnection conn = new(connectionString);
                conn.Open();
                string query = "DELETE Admin where IdAdmin = @id";
                SqlCommand cmd = new(query, conn);
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException sqlExc)
            {
                throw new Exception("A database error has ocurred", sqlExc);
            }
            catch (Exception Exc)
            {
                throw new Exception("An error has ocurred", Exc);
            }
        }

        public bool IsDNI(int dni)
        {
            try
            {
                SqlConnection conn = new(connectionString);
                string query = "SELECT COUNT(1) FROM Client WHERE DNI = @dni";
                conn.Open();

                SqlCommand cmd = new(query, conn);
                {
                    cmd.Parameters.AddWithValue("@dni", Convert.ToString(dni));
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }

            }
            catch(SqlException sqlExc)
            {
                throw new Exception("A database error has ocurred.", sqlExc);
            }
            catch (Exception exc)
            {
                throw new Exception ("An unknown error has ocurred. Try again.", exc);
            }
        }

        public Client SelectClient(int DNI)
        {
            try
            {
                SqlConnection conn = new(connectionString);
                string query = "SELECT ClientId, Name, Lastname, Email FROM Client WHERE DNI = @dni";
                conn.Open();
                SqlCommand cmd = new(query, conn);
                {
                    cmd.Parameters.AddWithValue("@dni", Convert.ToString(DNI));
                    using SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int idClient = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string lastname = reader.GetString(2);
                        string email = reader.GetString(3);

                        Client client = new(idClient, DNI, name, lastname, email);
                        return client;
                    }
                    else return null; // No client found with the given DNI
                }
            }
            catch (SqlException sqlExc)
            {
                throw new Exception("A database error has ocurred.", sqlExc);
            }
            catch (Exception exc)
            {
                throw new Exception("An unknown error has ocurred. Try again.", exc);
            }
        }
    }
}
