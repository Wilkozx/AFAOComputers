using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 UserId;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToInt32(Session["UserId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsUserCollection UserList = new clsUserCollection();

        UserList.ThisUser.Find(UserId);

        UserList.Delete();

        Response.Redirect("UserList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserList.aspx");
    }
}