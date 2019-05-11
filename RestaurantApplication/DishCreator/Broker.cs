using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using RestaurantApplication;

namespace DishCreator
{
    public class Broker
    {
        private SqlConnection SqlConnection;

        SqlConnectionStringBuilder SqlConnectionStringBuilder;
        void ConnectTo()
        {
            SqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            //Data Source = DESKTOP - RSHGEF8; Integrated Security = True
            SqlConnectionStringBuilder.DataSource = "DESKTOP-RSHGEF8";
            SqlConnectionStringBuilder.InitialCatalog = "Restaurant";
            SqlConnectionStringBuilder.IntegratedSecurity = true;

            SqlConnection = new SqlConnection(SqlConnectionStringBuilder.ToString());

        }


        public Broker()
        {
            ConnectTo();
        }

        public void Insert(MainDish mainDish)
        {
            try
            {
                string cmText = "INSERT INTO dbo.MainDish(Name, Price) VALUES(@Name, @Price)";
                SqlCommand command = new SqlCommand(cmText, SqlConnection);
                command.Parameters.AddWithValue("@Name", mainDish.Name);
                command.Parameters.AddWithValue("@Price", mainDish.Price);
                SqlConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Insert failed on exeption: {e}");
            }
            finally
            {
                if (SqlConnection != null)
                {
                    SqlConnection.Close();
                }
            }
        }


        public void Update(MainDish mainDish)
        {
            try
            {

                // UPDATE dbo.MainDish SET Name = 'ChickenBreast', Price = 42 WHERE Price = 42
                string cmText = "UPDATE dbo.MainDish SET Name = @Name,   Price = @Price WHERE Price = @OldPrice";
                SqlCommand command = new SqlCommand(cmText, SqlConnection);
                command.Parameters.AddWithValue("@Name", mainDish.Name);
                command.Parameters.AddWithValue("@OldPrice", mainDish.Price);
                command.Parameters.AddWithValue("@Price", 70);
                SqlConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Update failed on exeption: {e}");
            }
            finally
            {
                if (SqlConnection != null)
                {
                    SqlConnection.Close();
                }
            }
        }

        public string Select(MainDish mainDish)
        {
            try
            {

                // UPDATE dbo.MainDish SET Name = 'ChickenBreast', Price = 42 WHERE Price = 42
                string cmText = "SELECT * FROM dbo.MainDish WHERE Price = @Price";
                SqlCommand command = new SqlCommand(cmText, SqlConnection);

                command.Parameters.AddWithValue("@Price", mainDish.Price);
                //command.Parameters.AddWithValue("@Name", mainDish.Name);
                //command.Parameters.AddWithValue("@OldPrice", mainDish.Price);
                //command.Parameters.AddWithValue("@Price", 70);
                SqlConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                string name = null;
                if (reader.Read())
                {
                    name = reader["Name"].ToString();
                }
                else
                {
                    throw new Exception($"Name with price '{mainDish.Price}' was not found ");
                }

                return name;

            }
            catch (Exception e)
            {
                throw new Exception($"Update failed on exeption: {e}");
            }
            finally
            {
                if (SqlConnection != null)
                {
                    SqlConnection.Close();
                }
            }
        }

    }
}
