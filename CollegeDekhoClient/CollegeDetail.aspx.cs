using CollegeDekhoClient.CollegeReference;
using CollegeDekhoClient.CourseReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeDekhoClient
{
    public partial class CollegeDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CollegeReference.CollegeServiceClient cs = new CollegeReference.CollegeServiceClient();
            CourseReference.CourseServiceClient cr = new CourseReference.CourseServiceClient();
            College college;
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["collegeId"]))
                {
                    string collegeId = Request.QueryString["collegeId"];
                    int collegeID = int.Parse(collegeId);
                    college = cs.GetCollegeById(collegeID);
                    name.Text = college.Name;
                    desc.Text = college.Description;
                    uniType.Text = college.University;
                    place.Text = college.Place;
                    established.Text = "Year " + college.Established;
                    gym.Text = college.Gyn;
                    image.ImageUrl = college.ImageUrl;
                    canteen.Text = college.Canteen;
                    acre.Text = college.CampusSize + " Acre";
                    library.Text = college.Library;
                    sports.Text = college.Sports;
                    phone.Text = college.Phone;
                    email.Text = college.Email;
                    website.Text = college.Website;
                    naac.Text = college.NAAC;
                    nirf.Text = college.NIRF;
                    type.Text = college.Type;

                    List<Course> courses = cr.GetCoursesByCollegeId(collegeID).ToList();
                    courseRepeater.DataSource = courses;
                    courseRepeater.DataBind();
                }
            }
        }

        protected void button_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected string GenerateStars(object ratingObj)
        {
            int rating = ratingObj != DBNull.Value ? Convert.ToInt32(ratingObj) : 0;
            int maxStars = 5; // Total number of stars
            StringBuilder starsBuilder = new StringBuilder();

            for (int i = 1; i <= maxStars; i++)
            {
                if (i <= rating)
                {
                    starsBuilder.Append("<i class='fa-solid fa-star'></i>");
                }
                else
                {
                    starsBuilder.Append("<i class='fa-regular fa-star'></i>");
                }
            }

            return starsBuilder.ToString();
        }

    }
}