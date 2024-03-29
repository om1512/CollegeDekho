using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDekhoService
{
    internal class AdminService : IAdminService
    {

        string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public bool findAdminByUsernameAndPassword(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM [dbo].[Admin] WHERE [username] = @username AND [password] = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        

        public Admin GetAdminById(int adminId)
        {
            throw new NotImplementedException();
        }
    }
}
