using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Entity_Layer;

namespace Data_Layer
{

    public class AdminRepository
    {
        readonly string connectionString = "Server=ELIZABETH\\MSSQLSERVER2026; Database=SalesDB; TrustServerCertificate = True; Trusted_Connection = True;";

        public bool InsertAdmin(Admin admin)
        {
            try
            {
                SqlConnection con = new(connectionString);
                con.Open();
                string query = "INSERT INTO Admin (DNI, Name, Lastname, Password) VALUES (@DNI, @Name, @Lastname, @Password) ";
                SqlCommand cmd = new(query, con);
                {
                    string dni = Convert.ToString(admin.DNI);
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.Parameters.AddWithValue("@Name", admin.Name);
                    cmd.Parameters.AddWithValue("@Lastname", admin.Lastname);
                    cmd.Parameters.AddWithValue("@Password", admin.Password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch(SqlException sqlExc)
            {
                throw new Exception("An error in the database ocurred. ", sqlExc);
            }
            catch (Exception exc)
            {
                throw new Exception("An error ocurred", exc);
            }
        }

        public bool DeleteAdmin(int idAdmin)
        {
            try
            {
                SqlConnection conn = new(connectionString);
                conn.Open();
                string query = $"DELETE FROM Admin WHERE IdAdmin = {idAdmin}";
                SqlCommand cmd =  new(query, conn);
                {
                    return  cmd.ExecuteNonQuery() > 0;
                }

            }
            catch (SqlException sqlExc)
            {
                throw new Exception("An error in the database ocurred.", sqlExc);
            }
            catch (Exception exc)
            {
                throw new Exception("An unknown error has ocurred.", exc);
            }
        }
        
        public bool UpdateAdmin(Admin admin)
        {
            try
            {
                SqlConnection conn = new(connectionString);
                conn.Open();
                string query = "UPDATE Admin SET Name = @Name WHERE IdAdmin = @id" ;
                SqlCommand cmd = new(query, conn);
                {
                    cmd.Parameters.AddWithValue("@IdAdmin", admin.IdAdmin);
                    cmd.Parameters.AddWithValue("@DNI", admin.DNI);
                    cmd.Parameters.AddWithValue("@Name", admin.Name);
                    cmd.Parameters.AddWithValue("@Lastname", admin.Lastname);
                    cmd.Parameters.AddWithValue("@Password", admin.Password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException sql)
            {
                throw new Exception("An error has ocurred in the database", sql);
            }
            catch (Exception exc)
            {
                throw new Exception("An error has ocurred", exc);
            }
        }

        public bool IsDNI(int dni)
        {
            SqlConnection conn = new(connectionString);
            string query = "SELECT COUNT(1) FROM Admin WHERE DNI = @dni";
            conn.Open();
            SqlCommand cmd = new(query, conn);
            {
                cmd.Parameters.AddWithValue("@dni", dni);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public bool IsAdmin(int dni, string password)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            string query = "SELECT CASE WHEN EXISTS (SELECT 1 FROM Products WHERE DNI = @dni  AND Password = @password) THEN 1 ELSE 0 END";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@password", password);

            bool exists = (int)cmd.ExecuteScalar() == 1;
            conn.Close();
            return exists;
        }

        public int SelectIdAdmin(int dni)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            string query = "SELECT 1 FROM Admin WHERE DNI = @dni";
            SqlCommand cmd = new(query, conn);
            {
                cmd.Parameters.AddWithValue("@dni", dni);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    return id;
                }
                else return 0;
            }
        }

        public Admin SelectAdmin(int DNI, string password)
        {
            try
            {
                SqlConnection conn = new(connectionString);
                string query = "SELECT FROM Admin WHERE DNI = @dni AND Password = @password";
                conn.Open();
                SqlCommand cmd = new(query, conn);
                {
                    cmd.Parameters.AddWithValue("@dni", DNI);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = (int)reader.GetInt32(0);
                        int dni = (int)reader.GetInt32(1);
                        string name = reader.GetString(2);
                        string lastname = reader.GetString(3);
                        string passw = reader.GetString(4);
                        Admin admin = new(id, dni, name, lastname, passw);

                        return admin;
                    }
                    else return null;
                }
            }
            catch (SqlException sqlExc)
            {
                throw new Exception("Database error. Try again.", sqlExc);
            }
            catch (Exception Exc)
            {
                throw new Exception("An unknown error ocurred. Try again.", Exc);
            }
        }
    }
}
