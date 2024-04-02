using CollegeDekhoClient.CollegeReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace CollegeDekhoClient
{
    public partial class HomePage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindColleges();
            }
        }

        protected void BindColleges()
        {
            CollegeReference.CollegeServiceClient cs = new CollegeReference.CollegeServiceClient();
            List<College> collegeList = cs.listOfAllCollege().ToList();
            collegeRepeater.DataSource = collegeList;
            collegeRepeater.DataBind();
        }



        protected void collegeCardPanel_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = (LinkButton)sender;
            string collegeId = linkButton.CommandArgument;

            Response.Redirect("CollegeDetail.aspx?collegeId="+collegeId);
        }

        protected void AdminLoginClick(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }


        protected void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string query = searchTextBox.Text.Trim();
            SearchData(query);
        }

        protected void SearchData(string query)
        {
            // Fetch data from the WCF service
            CollegeReference.CollegeServiceClient cs = new CollegeReference.CollegeServiceClient();
            List<College> collegeList = cs.listOfAllCollege().ToList();
            List<College> filteredData = collegeList.Where(item =>
                item.Name.Contains(query) ||
                item.Place.Contains(query)
            ).ToList();

            // Bind the filtered data to your UI element
            collegeRepeater.DataSource = filteredData;
            collegeRepeater.DataBind();
        }



    }
}