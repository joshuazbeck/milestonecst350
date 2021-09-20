using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Milestone.Models;

namespace Milestone.Service
{
    public class SecurityDA
    {

        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MilestoneDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool findUser(UserModel user)
        {
            bool found = false;
            string query = "Select * from [dbo].[Users] where Username = @username and Password = @password";

            using (SqlConnection connect = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(query, connect);

                command.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 50).Value = user.Username;
                command.Parameters.Add("@PASSWORD", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

                try
                {
                    connect.Open();
                    SqlDataReader read = command.ExecuteReader();

                    if(read.HasRows)
                    {
                        found = true;
                    }
                }
                catch (Exception ex)

                {
                    Console.WriteLine(ex.Message);
                }
            }

            return found;
        }

        public bool createUser(UserModel user)
        {
            bool found = false;
            string query = "INSERT INTO dbo.Users (First_Name, Last_Name, Sex, Age, State, Email_Address, Username, Password) VALUES (@firstname, @lastname, @sex, @age, @state, @email, @username, @password)";

            using (SqlConnection connect = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(query, connect);

                
                command.Parameters.Add("@FIRSTNAME", System.Data.SqlDbType.VarChar, 50).Value = user.FirstName; 
                command.Parameters.Add("@LASTNAME", System.Data.SqlDbType.VarChar, 50).Value = user.LastName;
                command.Parameters.Add("@SEX", System.Data.SqlDbType.VarChar, 1).Value = user.Sex;
                command.Parameters.Add("@AGE", System.Data.SqlDbType.Int).Value = user.Age;
                command.Parameters.Add("@STATE", System.Data.SqlDbType.VarChar, 50).Value = user.State;
                command.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar, 50).Value = user.EmailAddress;
                command.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 50).Value = user.Username;
                command.Parameters.Add("@PASSWORD", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

                try
                {
                    connect.Open();
                    int read = command.ExecuteNonQuery();

                    if (read > 0)
                    {
                        found = true;
                    }
                }
                catch (Exception ex)

                {
                    Console.WriteLine(ex.Message);
                }
            }

            return found;
        }
    }
}
