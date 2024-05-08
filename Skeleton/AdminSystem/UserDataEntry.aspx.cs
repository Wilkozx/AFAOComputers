using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsUser
        clsUser AUser = new clsUser();
        //capture UserId
        AUser.UserName = txtUserName.Text;
        //store the address in the session object
        Session["AUser"] = AUser;
        //Navigate to the view page
        Response.Redirect("UserViewer.aspx");

    }
}