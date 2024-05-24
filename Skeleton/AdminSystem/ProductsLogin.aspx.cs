using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class ProductsLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //creating the instance of the product account class
        clsProductAccount AnAcccount = new clsProductAccount();
        //create the variable to store the username and password
        string UserName = TxtUserName.Text;
        string PassWord = txtPassWord.Text;
        //create boolean
        Boolean Found =false;
        //get the details  entered
        UserName = Convert.ToString(TxtUserName.Text);
        PassWord = Convert.ToString(txtPassWord.Text);
        //find the record
        Found = AnAcccount.FindAccount(UserName, PassWord);
        //if the acount exist
        if (TxtUserName.Text == "")
        {
            lblError.Text = "Enter a Username";
        }else if (txtPassWord.Text == "")
        {
            lblError.Text = "Enter a valid Password";
        }else if (Found ==true)
        {
            Response.Redirect("ProductsList.aspx");
        }else if (Found ==false)
        {
            lblError.Text = "Login Details are incorrect. Please try again: ";
        }

    }
}