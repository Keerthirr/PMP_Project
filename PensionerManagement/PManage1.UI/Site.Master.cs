using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PManage1.UI
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");

        }

        protected void btnprivacy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Privacy.aspx");

        }

        protected void btnabout_Click(object sender, EventArgs e)
        {
            Response.Redirect("About1.aspx");

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

        }
    }
}