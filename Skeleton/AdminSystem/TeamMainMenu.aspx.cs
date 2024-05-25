using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnProducts_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductsLogin.aspx");
    }

    protected void BtnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("");
    }

    protected void BtnUsers_Click(object sender, EventArgs e)
    {
        Response.Redirect("");
    }

    protected void BtnOrders_Click(object sender, EventArgs e)
    {
        Response.Redirect("");
    }
}