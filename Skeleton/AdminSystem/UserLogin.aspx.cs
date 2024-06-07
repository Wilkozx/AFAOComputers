
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // create an instance of the class
        clsUserAccount AnAccount = new clsUserAccount();
        // create variable to store username and password
        string UserName = txtUsername.Text;
        string PassWord = txtPassword.Text;
        // create a variable to store result of find user operation
        Boolean Found = false;
        // get username entered by user
        UserName = Convert.ToString(txtUsername.Text);
        PassWord = Convert.ToString(txtPassword.Text);
        // find the record
        Found = AnAccount.FindAccount(UserName, PassWord);
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