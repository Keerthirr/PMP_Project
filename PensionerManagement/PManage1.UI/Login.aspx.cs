using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PManage1.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string un = txtun.Text;
            string pw = txtpw.Text;
            if (un == "Keerthi" && pw == "9908")
            {
                Response.Redirect("Details.aspx");
            }
            else
            {
                lblmsg.Text = "Invalid User details";
            }

        }
    }
}