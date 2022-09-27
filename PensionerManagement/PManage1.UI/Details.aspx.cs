using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PManage1.UI
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");

        }

        protected void btndetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("GetDetails.aspx");

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delete.aspx");

        }
    }
}