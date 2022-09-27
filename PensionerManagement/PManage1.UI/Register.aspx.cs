using Pmanage.BusinessLayer;
using PManage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PManage1.UI
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Pensioner(object sender, EventArgs e)
        {
            try
            {
                Pensioner pensioner = new Pensioner();
                pensioner.PensionerID = int.Parse(txtpid.Text);
                pensioner.AadharID = txtaid.Text;
                pensioner.Names = txtname.Text;
                pensioner.Age = int.Parse(txtage.Text);
                pensioner.Gender = radiobutton0.Text;
                pensioner.Address = txtaddress.Text;
                pensioner.MobileNo = txtmobileno.Text;
                pensioner.BankName = txtbankname.Text;
                pensioner.AccountNumber = txtaccountnumber.Text;
                pensioner.PensionAmount = txtpensionamount.Text;
                pensioner.Reason = ddl1.Text;
                PensionerService pensionerService = new PensionerService();
                pensionerService.AddPension(pensioner);
                lbnmsg.Text = "RecordAdded";

            }
            catch (Exception ex)
            {

                lbnmsg.Text = ex.Message;

            }
        }
    }
}