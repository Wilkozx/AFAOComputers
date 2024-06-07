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
    Int32 UserId;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToInt32(Session["UserId"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (UserId != -1)
                DisplayUser();

        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserList.aspx");
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
        Error = AUser.Valid(UserName,Email,DateOfBirth,Password, PhoneNumber);
        if (Error == "")
        {
            //capture UserId
            AUser.UserId = UserId;
            AUser.UserName = UserName;
            AUser.Email = Email;
            AUser.isStaff = chkboxStaff.Checked;
            AUser.PhoneNumber = Convert.ToInt32(PhoneNumber);
            AUser.HashedPass = txtPassword.Text;
            AUser.DateofBirth = Convert.ToDateTime(DateOfBirth);

            clsUserCollection UserList = new clsUserCollection();
            if (UserId == -1)
            {
                UserList.ThisUser = AUser;
                UserList.Add();
            }
            else
            {
                UserList.ThisUser.Find(UserId);
                UserList.ThisUser = AUser;
                UserList.Update();
            }
           
            
            //Navigate to the view page
            Response.Redirect("UserList.aspx");
        }
        else
        {
           ERROR.Text = Error;
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
        
        // Find the record
        try 
        { 
            UserId = Convert.ToInt32(txtUserId.Text);
            Found = AUser.Find(UserId); 
        }
        catch 
        { 
            ERROR.Text = "Input User ID"; 
        }
        
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
            
            ERROR.Text = "Could not find";
        }
        
    }
    void DisplayUser()
    {
        clsUserCollection UserList = new clsUserCollection();
        UserList.ThisUser.Find(UserId);
        txtUserId.Text = UserList.ThisUser.UserId.ToString();
        txtUserName.Text = UserList.ThisUser.UserName;
        txtEmail.Text = UserList.ThisUser.Email;
        txtPassword.Text = UserList.ThisUser.HashedPass;
        chkboxStaff.Checked = UserList.ThisUser.isStaff;
        txtDateofBirth.Text = UserList.ThisUser.DateofBirth.ToString("d");
        txtPhoneNumber.Text = UserList.ThisUser.PhoneNumber.ToString();




    }



    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
