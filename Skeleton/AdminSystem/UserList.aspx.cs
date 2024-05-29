using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) 
        {
            DisplayUsers();
        }

    }
    void DisplayUsers()
    {
        clsUserCollection Users = new clsUserCollection();
        lstUserList.DataSource = Users.UserList;
        lstUserList.DataValueField = "Name";
        lstUserList.DataTextField = "Email";
        lstUserList.DataBind();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["UserId"] = -1;

        Response.Redirect("UserDataList.aspx");

    }
}