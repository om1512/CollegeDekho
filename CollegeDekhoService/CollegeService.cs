using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDekhoService
{
    public class CollegeService : ICollegeService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public void DeleteCollegeById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand deleteCoursesCommand = connection.CreateCommand();
                deleteCoursesCommand.CommandText = "DELETE FROM CourseDetails WHERE college_id = @CollegeId";
                deleteCoursesCommand.Parameters.AddWithValue("@CollegeId", id);
                deleteCoursesCommand.ExecuteNonQuery();
                SqlCommand deleteCollegeCommand = connection.CreateCommand();
                deleteCollegeCommand.CommandText = "DELETE FROM College WHERE Id = @Id";
                deleteCollegeCommand.Parameters.AddWithValue("@Id", id);
                deleteCollegeCommand.ExecuteNonQuery();
            }
        }

        public DataSet GetAllColleges()
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM College";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataSet);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return dataSet;
        }

        public College GetCollegeById(int id)
        {
            College college = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM College WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            college = new College
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["name"],
                                Description = (string)reader["desc"],
                                University = (string)reader["university"],
                                Place = (string)reader["place"],
                                Established = reader["established"] == DBNull.Value ? (int?)null : (int)reader["established"],
                                ImageUrl = (string)reader["imageUrl"],
                                Phone = (string)reader["phone"],
                                Email = (string)reader["email"],
                                Website = (string)reader["website"],
                                Type = (string)reader["type"],
                                CampusSize = reader["campusSize"] == DBNull.Value ? (int?)null : (int)reader["campusSize"],
                                Gyn = (string)reader["gyn"],
                                Canteen = (string)reader["canteen"],
                                Sports = (string)reader["sports"],
                                NAAC = (string)reader["NAAC"],
                                NIRF = (string)reader["NIRF"],
                                Library = (string)reader["library"]
                            };
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return college;
        }

        public College GetCollegeByName(string name)
        {
            College college = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM College WHERE [name] = @Name";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            college = new College
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["name"],
                                Description = (string)reader["desc"],
                                University = (string)reader["university"],
                                Place = (string)reader["place"],
                                Established = reader["established"] == DBNull.Value ? (int?)null : (int)reader["established"],
                                ImageUrl = (string)reader["imageUrl"],
                                Phone = (string)reader["phone"],
                                Email = (string)reader["email"],
                                Website = (string)reader["website"],
                                Type = (string)reader["type"],
                                CampusSize = reader["campusSize"] == DBNull.Value ? (int?)null : (int)reader["campusSize"],
                                Gyn = (string)reader["gyn"],
                                Canteen = (string)reader["canteen"],
                                Sports = (string)reader["sports"],
                                NAAC = (string)reader["NAAC"],
                                NIRF = (string)reader["NIRF"],
                                Library = (string)reader["library"]
                            };
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return college;
        }


        public College GetCollegeByPlace(string place)
        {
            College college = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM College WHERE [place] = @Place";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Place", place);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            college = new College
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["name"],
                                Description = (string)reader["desc"],
                                University = (string)reader["university"],
                                Place = (string)reader["place"],
                                Established = reader["established"] == DBNull.Value ? (int?)null : (int)reader["established"],
                                ImageUrl = (string)reader["imageUrl"],
                                Phone = (string)reader["phone"],
                                Email = (string)reader["email"],
                                Website = (string)reader["website"],
                                Type = (string)reader["type"],
                                CampusSize = reader["campusSize"] == DBNull.Value ? (int?)null : (int)reader["campusSize"],
                                Gyn = (string)reader["gyn"],
                                Canteen = (string)reader["canteen"],
                                Sports = (string)reader["sports"],
                                NAAC = (string)reader["NAAC"],
                                NIRF = (string)reader["NIRF"],
                                Library = (string)reader["library"]
                            };
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return college;
        }


        public List<College> listOfAllCollege()
        {
            List<College> colleges = new List<College>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM College";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        College college = new College
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Name = Convert.ToString(row["name"]),
                            Description = Convert.ToString(row["desc"]),
                            University = Convert.ToString(row["university"]),
                            Place = Convert.ToString(row["place"]),
                            Established = row["established"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["established"]),
                            ImageUrl = Convert.ToString(row["imageUrl"]),
                            Phone = Convert.ToString(row["phone"]),
                            Email = Convert.ToString(row["email"]),
                            Website = Convert.ToString(row["website"]),
                            Type = Convert.ToString(row["type"]),
                            CampusSize = row["campusSize"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["campusSize"]),
                            Gyn = Convert.ToString(row["gyn"]),
                            Canteen = Convert.ToString(row["canteen"]),
                            Sports = Convert.ToString(row["sports"]),
                            NAAC = Convert.ToString(row["NAAC"]),
                            NIRF = Convert.ToString(row["NIRF"]),
                            Library = Convert.ToString(row["library"])
                        };
                        colleges.Add(college);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return colleges;
        }

        public void saveCollege(College college)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open connection
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "INSERT INTO College (name, [desc], university, place, established, imageUrl, phone, email, website, [type], campusSize, gyn, canteen, sports, NAAC, NIRF, library) VALUES (@Name, @Description, @University, @Place, @Established, @ImageUrl, @Phone, @Email, @Website, @Type, @CampusSize, @Gyn, @Canteen, @Sports, @NAAC, @NIRF, @Library);";

                command.Parameters.AddWithValue("@Name", college.Name);
                command.Parameters.AddWithValue("@University", college.University);
                command.Parameters.AddWithValue("@Description", college.Description);
                command.Parameters.AddWithValue("@Place", college.Place);
                command.Parameters.AddWithValue("@Established", college.Established);
                command.Parameters.AddWithValue("@ImageUrl", college.ImageUrl);
                command.Parameters.AddWithValue("@Phone", college.Phone);
                command.Parameters.AddWithValue("@Email", college.Email);
                command.Parameters.AddWithValue("@Website", college.Website);
                command.Parameters.AddWithValue("@Type", college.Type);
                command.Parameters.AddWithValue("@CampusSize", college.CampusSize);
                command.Parameters.AddWithValue("@Gyn", college.Gyn);
                command.Parameters.AddWithValue("@Canteen", college.Canteen);
                command.Parameters.AddWithValue("@Library", college.Library);
                command.Parameters.AddWithValue("@Sports", college.Sports);
                command.Parameters.AddWithValue("@NAAC", college.NAAC);
                command.Parameters.AddWithValue("@NIRF", college.NIRF);

                // Execute command
                command.ExecuteNonQuery();
            }
        }

        public void SaveCollege(College college)
        {
            throw new NotImplementedException();
        }

        public string UpdateCollegeById(int id, College college)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE College SET name = @Name, [desc] = @Description, university = @University, place = @Place, established = @Established, imageUrl = @ImageUrl, phone = @Phone, email = @Email, website = @Website, [type] = @Type, campusSize = @CampusSize, gyn = @Gyn, canteen = @Canteen, sports = @Sports, NAAC = @NAAC, NIRF = @NIRF, library = @Library WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", college.Name);
                    command.Parameters.AddWithValue("@Description", college.Description);
                    command.Parameters.AddWithValue("@University", college.University);
                    command.Parameters.AddWithValue("@Place", college.Place);
                    command.Parameters.AddWithValue("@Established", college.Established);
                    command.Parameters.AddWithValue("@ImageUrl", college.ImageUrl);
                    command.Parameters.AddWithValue("@Phone", college.Phone);
                    command.Parameters.AddWithValue("@Email", college.Email);
                    command.Parameters.AddWithValue("@Website", college.Website);
                    command.Parameters.AddWithValue("@Type", college.Type);
                    command.Parameters.AddWithValue("@CampusSize", college.CampusSize);
                    command.Parameters.AddWithValue("@Gyn", college.Gyn);
                    command.Parameters.AddWithValue("@Canteen", college.Canteen);
                    command.Parameters.AddWithValue("@Sports", college.Sports);
                    command.Parameters.AddWithValue("@NAAC", college.NAAC);
                    command.Parameters.AddWithValue("@NIRF", college.NIRF);
                    command.Parameters.AddWithValue("@Library", college.Library);
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    return "Error : " + ex;
                }
                return "successfully updated...";
            }
        }
    }
}
