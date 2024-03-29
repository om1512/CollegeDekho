using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDekhoService
{
    internal class CourseService : ICourseService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public void AddCourse(Course course)
        {
            // Create the SQL INSERT query
            string query = @"INSERT INTO CourseDetails (college_id, type, degree, name, description, duration, fees, rating, placement_rate, median_salary,
                            total_available_seats, general_seat, obc_seat, sc_seat, st_seat, opening_home_state_rank, closing_home_state_rank,
                            general_opening_rank_Gujcat, general_closing_rank_Gujcat, general_opening_rank_Jee, general_closing_rank_Jee,
                            obc_opening_rank_Gujcat, obc_closing_rank_Gujcat, obc_opening_rank_Jee, obc_closing_rank_Jee,
                            SC_opening_rank_Gujcat, SC_closing_rank_Gujcat, SC_opening_rank_Jee, SC_closing_rank_Jee,
                            ST_opening_rank_Gujcat, ST_closing_rank_Gujcat, ST_opening_rank_Jee, ST_closing_rank_Jee)
                            VALUES (@college_id, @type, @degree, @name, @description, @duration, @fees, @rating, @placement_rate, @median_salary,
                            @total_available_seats, @general_seat, @obc_seat, @sc_seat, @st_seat, @opening_home_state_rank, @closing_home_state_rank,
                            @general_opening_rank_Gujcat, @general_closing_rank_Gujcat, @general_opening_rank_Jee, @general_closing_rank_Jee,
                            @obc_opening_rank_Gujcat, @obc_closing_rank_Gujcat, @obc_opening_rank_Jee, @obc_closing_rank_Jee,
                            @SC_opening_rank_Gujcat, @SC_closing_rank_Gujcat, @SC_opening_rank_Jee, @SC_closing_rank_Jee,
                            @ST_opening_rank_Gujcat, @ST_closing_rank_Gujcat, @ST_opening_rank_Jee, @ST_closing_rank_Jee)";

            // Open a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command with the INSERT query and parameters
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@college_id", course.college_id);
                    command.Parameters.AddWithValue("@type", course.type);
                    command.Parameters.AddWithValue("@degree", course.degree);
                    command.Parameters.AddWithValue("@name", course.name);
                    command.Parameters.AddWithValue("@description", course.description);
                    command.Parameters.AddWithValue("@duration", course.duration);
                    command.Parameters.AddWithValue("@fees", course.fees);
                    command.Parameters.AddWithValue("@rating", course.rating);
                    command.Parameters.AddWithValue("@placement_rate", course.placement_rate);
                    command.Parameters.AddWithValue("@median_salary", course.median_salary);
                    command.Parameters.AddWithValue("@total_available_seats", course.total_available_seats);
                    command.Parameters.AddWithValue("@general_seat", course.general_seat);
                    command.Parameters.AddWithValue("@obc_seat", course.obc_seat);
                    command.Parameters.AddWithValue("@sc_seat", course.sc_seat);
                    command.Parameters.AddWithValue("@st_seat", course.st_seat);
                    command.Parameters.AddWithValue("@opening_home_state_rank", course.opening_home_state_rank);
                    command.Parameters.AddWithValue("@closing_home_state_rank", course.closing_home_state_rank);
                    command.Parameters.AddWithValue("@general_opening_rank_Gujcat", course.general_opening_rank_Gujcat);
                    command.Parameters.AddWithValue("@general_closing_rank_Gujcat", course.general_closing_rank_Gujcat);
                    command.Parameters.AddWithValue("@general_opening_rank_Jee", course.general_opening_rank_Jee);
                    command.Parameters.AddWithValue("@general_closing_rank_Jee", course.general_closing_rank_Jee);
                    command.Parameters.AddWithValue("@obc_opening_rank_Gujcat", course.obc_opening_rank_Gujcat);
                    command.Parameters.AddWithValue("@obc_closing_rank_Gujcat", course.obc_closing_rank_Gujcat);
                    command.Parameters.AddWithValue("@obc_opening_rank_Jee", course.obc_opening_rank_Jee);
                    command.Parameters.AddWithValue("@obc_closing_rank_Jee", course.obc_closing_rank_Jee);
                    command.Parameters.AddWithValue("@SC_opening_rank_Gujcat", course.SC_opening_rank_Gujcat);
                    command.Parameters.AddWithValue("@SC_closing_rank_Gujcat", course.SC_closing_rank_Gujcat);
                    command.Parameters.AddWithValue("@SC_opening_rank_Jee", course.SC_opening_rank_Jee);
                    command.Parameters.AddWithValue("@SC_closing_rank_Jee", course.SC_closing_rank_Jee);
                    command.Parameters.AddWithValue("@ST_opening_rank_Gujcat", course.ST_opening_rank_Gujcat);
                    command.Parameters.AddWithValue("@ST_closing_rank_Gujcat", course.ST_closing_rank_Gujcat);
                    command.Parameters.AddWithValue("@ST_opening_rank_Jee", course.ST_opening_rank_Jee);
                    command.Parameters.AddWithValue("@ST_closing_rank_Jee", course.ST_closing_rank_Jee);

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
    

    public void DeleteCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public Course GetCourseById(int courseId)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCoursesByCollegeId(int collegeId)
        {
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CourseDetails WHERE college_id = @CollegeId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CollegeId", collegeId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Course course = new Course
                    {
                        ID = (int)reader["ID"],
                        college_id = (int)reader["college_id"],
                        type = reader["type"].ToString(),
                        degree = reader["degree"].ToString(),
                        name = reader["name"].ToString(),
                        description = reader["description"].ToString(),
                        duration = reader["duration"].ToString(),
                        fees = (decimal)reader["fees"],
                        rating = (decimal)reader["rating"],
                        placement_rate = (decimal)reader["placement_rate"],
                        median_salary = (decimal)reader["median_salary"],
                        total_available_seats = (int)reader["total_available_seats"],
                        general_seat = (int)reader["general_seat"],
                        obc_seat = (int)reader["obc_seat"],
                        sc_seat = (int)reader["sc_seat"],
                        st_seat = (int)reader["st_seat"],
                        opening_home_state_rank = (int)reader["opening_home_state_rank"],
                        closing_home_state_rank = (int)reader["closing_home_state_rank"],
                        general_opening_rank_Gujcat = (int)reader["general_opening_rank_Gujcat"],
                        general_closing_rank_Gujcat = (int)reader["general_closing_rank_Gujcat"],
                        general_opening_rank_Jee = (int)reader["general_opening_rank_Jee"],
                        general_closing_rank_Jee = (int)reader["general_closing_rank_Jee"],
                        obc_opening_rank_Gujcat = (int)reader["obc_opening_rank_Gujcat"],
                        obc_closing_rank_Gujcat = (int)reader["obc_closing_rank_Gujcat"],
                        obc_opening_rank_Jee = (int)reader["obc_opening_rank_Jee"],
                        obc_closing_rank_Jee = (int)reader["obc_closing_rank_Jee"],
                        SC_opening_rank_Gujcat = (int)reader["SC_opening_rank_Gujcat"],
                        SC_closing_rank_Gujcat = (int)reader["SC_closing_rank_Gujcat"],
                        SC_opening_rank_Jee = (int)reader["SC_opening_rank_Jee"],
                        SC_closing_rank_Jee = (int)reader["SC_closing_rank_Jee"],
                        ST_opening_rank_Gujcat = (int)reader["ST_opening_rank_Gujcat"],
                        ST_closing_rank_Gujcat = (int)reader["ST_closing_rank_Gujcat"],
                        ST_opening_rank_Jee = (int)reader["ST_opening_rank_Jee"],
                        ST_closing_rank_Jee = (int)reader["ST_closing_rank_Jee"]
                    };
                    courses.Add(course);
                }
            }

            return courses;
        }

        public void UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
