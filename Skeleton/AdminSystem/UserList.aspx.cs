using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security.Tokens;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //UserId = Convert.ToInt32(Session["UserId"]);
        if (IsPostBack == false) 
        {
            DisplayUsers();
        }

    }
    
    void DisplayUsers()
    {
        clsUserCollection Users = new clsUserCollection();
        lstUserList.DataSource = Users.UserList;
        lstUserList.DataValueField = "UserId";
        lstUserList.DataTextField = "UserName";
        lstUserList.DataBind();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["UserId"] = -1;

        Response.Redirect("UserDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 UserId;
        if (lstUserList.SelectedIndex != -1)
        {
            UserId = Convert.ToInt32(lstUserList.SelectedValue);
            Session["UserId"] = UserId;
            Response.Redirect("UserDataEntry.aspx");
        }
        else
        {
            lblError.Text = " please select a record from the list to edit";
        }
    }
}