using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // creat an instance of the class
        clsUserAccount AnAccount = new clsUserAccount();
        // creat variable to store username and password
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        // create a variable to store result of find user operation
        Boolean Found = false;
        // get username entered by user
        Username = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);
        // find the record
        Found = AnAccount.FindAccount(Username, Password);
        // add session to capture username
        Session["AnAccount"] = AnAccount;
        // if username/password is empty
        if (txtUsername.Text == "")
        {
            // record error
            lblError.Text = "Enter a username ";
        }
        else if (txtPassword.Text == "")
        {
            // record error
            lblError.Text = "Enter a password ";
        }
        // if found
        else if (Found == true)
        {
            //redirect to list page
            Response.Redirect("UserList.aspx");
        }
        else if (Found == false)
        {
            // record error
            lblError.Text = "Login details are incorrect. Please try again ";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}