using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace One_Real_Estate___Database.Sprint_1
{
    public partial class Login_Successful_Page : System.Web.UI.Page
    {
        String userName;

        protected void Page_Load(object sender, EventArgs e)
        {
            userName = (String)(Session["userNameFetched"]);
            if (userName == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("Login_Page", false);
            }
            else
            {
                Welcome_Label.Text = userName;
            }
        }

        protected void Logout_Button_Click(object sender, EventArgs e)
        {
            Session["userNameFetched"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("Login_Page", false);
        }
    }
}