using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
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
        string UserName = txtUserName.Text;
        string Email = txtEmail.Text;
        string Password = txtPassword.Text; 
        string PhoneNumber = Convert.ToString(txtPhoneNumber.Text);
        string DateOfBirth = txtDateofBirth.Text;
        string isStaff = Convert.ToString(chkboxStaff.Text);
        string Error = "";
        Error = AUser.Valid(UserName,Email,DateOfBirth,PhoneNumber, isStaff);
        if (Error == "")
        {
            //capture UserId
            AUser.UserName = txtUserName.Text;
            AUser.Email = txtEmail.Text;
            AUser.isStaff = chkboxStaff.Checked;
            AUser.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
            AUser.HashedPass = txtPassword.Text;
            AUser.DateofBirth = Convert.ToDateTime(txtDateofBirth.Text);
            //store the address in the session object
            Session["AUser"] = AUser;
            //Navigate to the view page
            Response.Redirect("UserViewer.aspx");
        }
        else
        {
           ERROR.InnerText = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the Staff class
        clsUser AUser = new clsUser();
        // Create a variable to store the primary key
        Int32 UserId;
        // Create a variable to store the result of the operation
        Boolean Found = false;
        // Get the primary key entered by the user
        UserId = Convert.ToInt32(txtUserId.Text);
        // Find the record
        Found = AUser.Find(UserId);
        // If Found...
        if (Found == true)
        {
            // Display the values of the properties in the form
            txtUserName.Text = AUser.UserName;
            txtEmail.Text = AUser.Email;
            txtPassword.Text = AUser.HashedPass;
            chkboxStaff.Checked = AUser.isStaff;
            txtDateofBirth.Text = AUser.DateofBirth.ToString("dd-mm-yyyy");
            txtPhoneNumber.Text = AUser.PhoneNumber.ToString();

        }
        else
        {
            ERROR.InnerText = "Bye";
        }
        
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
