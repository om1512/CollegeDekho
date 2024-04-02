using CollegeDekhoClient.CollegeReference;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeDekhoClient
{
    public partial class UpdateCollege : System.Web.UI.Page
    {
        CollegeReference.CollegeServiceClient cs = new CollegeReference.CollegeServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isAdminAuthenticated"] == null || !(bool)Session["isAdminAuthenticated"])
            {
                Response.Redirect("AdminLogin.aspx");
            }
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["collegeId"]))
                {
                    string collegeId = Request.QueryString["collegeId"];
                    int id = int.Parse(collegeId);
                    testLabel.Text =  " ID "+ id.ToString();
                    College college = cs.GetCollegeById(id);
                    name.Text = college.Name;
                    description.Text = college.Description;
                    university.Text = college.University;
                    place.Text = college.Place;
                    established.Text = college.Established.ToString();
                    gym.Text = college.Gyn;
                    imageUrl.Text= college.ImageUrl;
                    canteen.Text = college.Canteen;
                    campusSize.Text = college.CampusSize.ToString();
                    library.Text = college.Library;
                    sports.Text = college.Sports;
                    phone.Text = college.Phone;
                    email.Text = college.Email;
                    website.Text = college.Website;
                    NAAC.Text = college.NAAC;
                    NIRF.Text = college.NIRF;
                    type.Text = college.Type;
                }
            }
        }
        protected void save_Click(object sender, EventArgs e)
        {
            College college = new College();
            college.Name = name.Text;
            college.University = university.Text;
            college.Description = description.Text;
            college.Place = place.Text;
            college.Established = int.Parse(established.Text);
            college.ImageUrl = imageUrl.Text;
            college.Phone = phone.Text;
            college.Email = email.Text;
            college.Website = website.Text;
            college.Type = type.Text;
            college.CampusSize = int.Parse(campusSize.Text);
            college.Gyn = gym.Text;
            college.Canteen = canteen.Text;
            college.Library = library.Text;
            college.Sports = sports.Text;
            college.NAAC = NAAC.Text;
            college.NIRF = NIRF.Text;
            if (!string.IsNullOrEmpty(Request.QueryString["collegeId"]))
            {
                string collegeId = Request.QueryString["collegeId"];
                int id = int.Parse(collegeId);
                string response = cs.UpdateCollegeById(id, college);
                Response.Redirect("AdminDashboard.aspx");
            }
        }
    }
}