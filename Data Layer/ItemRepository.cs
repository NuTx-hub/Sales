using System;
using System.Collections.Generic;
using System.Text;
using Entity_Layer;
using Microsoft.Data.SqlClient;

namespace Data_Layer
{
    public class ItemRepository
    { 
        string connectionString = "Server=ELIZABETH\\MSSQLSERVER2026; Database=SalesDB; TrustServerCertificate = True; Trusted_Connection = True;";
        public bool insertItem(Item item)
        {
            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();
                string query = "INSERT INTO Item(Id, Name, Price, Stock, ExpireDate, Description, Barcode) VALUES (@Id, @Name, @Price, @Stock, @ExpireDate, @Description, @Barcode)";
                using SqlCommand cmd = new SqlCommand(query, conn);
                {
                    //Add the parameters to the command
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Name", item.Name);
                    cmd.Parameters.AddWithValue("@Price", item.Price);
                    cmd.Parameters.AddWithValue("@Stock", item.Stock);
                    cmd.Parameters.AddWithValue("@ExpireDate", item.ExpireDate);
                    cmd.Parameters.AddWithValue("@Description", item.Description);
                    cmd.Parameters.AddWithValue("@Barcode", item.Barcode);

                    //Execute the command and check if any rows were affected
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException sqlException)
            {
                throw new Exception("A database error has occurred while inserting the item.", sqlException);
            }
            catch (Exception exception)
            {
                throw new Exception("An error has occurred while inserting the item.", exception);
            }
        }
    }
}
