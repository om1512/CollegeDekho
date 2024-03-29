using CollegeDekhoClient.CollegeReference;
using CollegeDekhoClient.CourseReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeDekhoClient
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        CollegeReference.CollegeServiceClient cs = new CollegeReference.CollegeServiceClient();
        CourseReference.CourseServiceClient cr = new CourseReference.CourseServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isAdminAuthenticated"] == null || !(bool)Session["isAdminAuthenticated"])
            {
                Response.Redirect("AdminLogin.aspx");
            }
            CollegeReference.CollegeServiceClient cs = new CollegeReference.CollegeServiceClient();
            List<College> collegeList = cs.listOfAllCollege().ToList();
            collegeRepeater.DataSource = collegeList;
            collegeRepeater.DataBind();
        }
        private void BindGrid()
        {
            CollegeReference.CollegeServiceClient cs = new CollegeReference.CollegeServiceClient();
            List<College> collegeList = cs.listOfAllCollege().ToList();
            collegeRepeater.DataSource = collegeList;
            collegeRepeater.DataBind();
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

            name.Text = "";
            university.Text = "";
            description.Text = "";
            place.Text = "";
            established.Text = "";
            imageUrl.Text = "";
            phone.Text = "";
            email.Text = "";
            website.Text = "";
            type.Text = "";
            campusSize.Text = "";
            gym.Text = "";
            canteen.Text = "";
            library.Text = "";
            sports.Text = "";
            NAAC.Text = "";
            NIRF.Text = "";

            cs.saveCollege(college);
        }


        protected void collegeCardPanel_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = (LinkButton)sender;
            string collegeId = linkButton.CommandArgument;

            Response.Redirect("UpdateCollege.aspx?collegeId=" + collegeId);
        }

        protected void deleteButton(object sender, EventArgs e)
        {
            LinkButton linkButton = (LinkButton)sender;
            string collegeId = linkButton.CommandArgument;
            cs.DeleteCollegeById(int.Parse(collegeId));
            BindGrid();
        }

        protected void courseSave(object sender, EventArgs e)
        {
            Course newCourse = new Course();
            newCourse.college_id = Convert.ToInt32(txtCollegeId.Text);
            newCourse.type = txtType.Text;
            newCourse.degree = txtDegree.Text;
            newCourse.name = txtName.Text;
            newCourse.description = txtDescription.Text;
            newCourse.duration = txtDuration.Text;
            newCourse.fees = Convert.ToDecimal(txtFees.Text);
            newCourse.rating = Convert.ToDecimal(txtRating.Text);
            newCourse.placement_rate = Convert.ToDecimal(txtPlacementRate.Text);
            newCourse.median_salary = Convert.ToDecimal(txtMedianSalary.Text);
            newCourse.total_available_seats = Convert.ToInt32(txtTotalAvailableSeats.Text);
            newCourse.general_seat = Convert.ToInt32(txtGeneralSeat.Text);
            newCourse.obc_seat = Convert.ToInt32(txtObcSeat.Text);
            newCourse.sc_seat = Convert.ToInt32(txtScSeat.Text);
            newCourse.st_seat = Convert.ToInt32(txtStSeat.Text);
            newCourse.opening_home_state_rank = Convert.ToInt32(txtOpeningHomeStateRank.Text);
            newCourse.closing_home_state_rank = Convert.ToInt32(txtClosingHomeStateRank.Text);
            newCourse.general_opening_rank_Gujcat = Convert.ToInt32(txtGeneralOpeningRankGujcat.Text);
            newCourse.general_closing_rank_Gujcat = Convert.ToInt32(txtGeneralClosingRankGujcat.Text);
            newCourse.general_opening_rank_Jee = Convert.ToInt32(txtGeneralOpeningRankJee.Text);
            newCourse.general_closing_rank_Jee = Convert.ToInt32(txtGeneralClosingRankJee.Text);
            newCourse.obc_opening_rank_Gujcat = Convert.ToInt32(txtObcOpeningRankGujcat.Text);
            newCourse.obc_closing_rank_Gujcat = Convert.ToInt32(txtObcClosingRankGujcat.Text);
            newCourse.obc_opening_rank_Jee = Convert.ToInt32(txtObcOpeningRankJee.Text);
            newCourse.obc_closing_rank_Jee = Convert.ToInt32(txtObcClosingRankJee.Text);
            newCourse.SC_opening_rank_Gujcat = Convert.ToInt32(txtSCOpeningRankGujcat.Text);
            newCourse.SC_closing_rank_Gujcat = Convert.ToInt32(txtSCClosingRankGujcat.Text);
            newCourse.SC_opening_rank_Jee = Convert.ToInt32(txtSCOpeningRankJee.Text);
            newCourse.SC_closing_rank_Jee = Convert.ToInt32(txtSCClosingRankJee.Text);
            newCourse.ST_opening_rank_Gujcat = Convert.ToInt32(txtSTOpeningRankGujcat.Text);
            newCourse.ST_closing_rank_Gujcat = Convert.ToInt32(txtSTClosingRankGujcat.Text);
            newCourse.ST_opening_rank_Jee = Convert.ToInt32(txtSTOpeningRankJee.Text);
            newCourse.ST_closing_rank_Jee = Convert.ToInt32(txtSTClosingRankJee.Text);

            cr.AddCourse(newCourse);
        }
    }
}