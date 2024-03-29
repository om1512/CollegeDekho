using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeDekhoClient
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        AdminReference.AdminServiceClient adminServiceClient = new AdminReference.AdminServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginClick(object sender, EventArgs e)
        {
            string usernameValue = username.Text;
            string passwordValue = password.Text;
            bool status = adminServiceClient.findAdminByUsernameAndPassword(usernameValue, passwordValue);
            if(status)
            {
                Session["isAdminAuthenticated"] = true;
                Response.Redirect("AdminDashboard.aspx");
            }
            else
            {
                username.Text = "";
                password.Text = "";
            }
        }
    }
}