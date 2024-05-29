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
        string UserId = Convert.ToString(txtUserId.Text);
        string UserName = txtUserName.Text;
        string Email = txtEmail.Text;
        string Password = txtPassword.Text; 
        string PhoneNumber = Convert.ToString(txtPhoneNumber.Text);
        string DateOfBirth = txtDateofBirth.Text;
        string isStaff = Convert.ToString(chkboxStaff.Text);
        string Error = "";
        Error = AUser.Valid(UserName,Email,DateOfBirth);
        if (Error == "")
        {
            //capture UserId
            AUser.UserId = Convert.ToInt32(UserId);
            AUser.UserName = UserName;
            AUser.Email = Email;
            AUser.isStaff = chkboxStaff.Checked;
            AUser.PhoneNumber = Convert.ToInt32(PhoneNumber);
            AUser.HashedPass = txtPassword.Text;
            AUser.DateofBirth = Convert.ToDateTime(DateOfBirth);

            clsUserCollection UserList = new clsUserCollection();
            if (Convert.ToInt32(UserId) == -1)
            {
                UserList.ThisUser = AUser;
                UserList.Add();
            }
            else
            {
                UserList.ThisUser.Find(Convert.ToInt32(UserId));
                UserList.ThisUser = AUser;
                UserList.Update();
            }
           
            
            //Navigate to the view page
            Response.Redirect("UserList.aspx");
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
    void DisplayUser()
    {
        clsUserCollection UserList = new clsUserCollection();
        //UserList.ThisUser.Find(UserId);
        txtUserId.Text = UserList.ThisUser.UserId.ToString();
        txtUserName.Text = UserList.ThisUser.UserName;
        txtEmail.Text = UserList.ThisUser.Email;
        txtPassword.Text = UserList.ThisUser.HashedPass;
        chkboxStaff.Checked = UserList.ThisUser.isStaff;
        txtDateofBirth.Text = UserList.ThisUser.DateofBirth.ToString("dd-mm-yyyy");
        txtPhoneNumber.Text = UserList.ThisUser.PhoneNumber.ToString();



    }


    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
