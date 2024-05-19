using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        String staff_Id = txtStaffId.Text;
        String Firstname = txtFirstname.Text;
        String Lastname = txtLastname.Text;
        String hasPerms = txtHasPerms.Checked.ToString();
        String sortCode = txtSortcode.Text;
        String accountNumber = txtAccountNumber.Text;
        String joinDate = txtJoinDate.Text;
        String contractExpiry = txtExpiryDate.Text;

        // add active again for cache
        string Error = "";

        Error = AStaff.Valid(staff_Id, Firstname, Lastname, hasPerms, sortCode, accountNumber, joinDate, contractExpiry);
        if (Error == "")
        {
            AStaff.StaffId = Convert.ToInt32(staff_Id);
            AStaff.FirstName = Firstname;
            AStaff.LastName = Lastname;
            AStaff.HasPerms = Convert.ToBoolean(hasPerms);
            AStaff.PayeeDetails = sortCode + accountNumber; 
            AStaff.JoinDate = Convert.ToDateTime(joinDate);
            AStaff.ContractExpiary = Convert.ToDateTime(contractExpiry);
            Session["AStaff"] = AStaff;
            Response.Redirect("StaffViewer.aspx");
        } 
        else
        {
            error.InnerText = Error;
        }

        Session["AStaff"] = AStaff;
        // Navigate to view page
        Response.Redirect("StaffViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the Staff class
        clsStaff AStaff = new clsStaff();
        // Create a variable to store the primary key
        Int32 StaffId;
        // Create a variable to store the result of the operation
        Boolean Found = false;
        // Get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        // Find the record
        Found = AStaff.Find(StaffId);
        // If Found...
        if (Found == true)
        {
            // Display the values of the properties in the form
            txtFirstname.Text = AStaff.FirstName;
            txtLastname.Text = AStaff.LastName;
            txtSortcode.Text = AStaff.PayeeDetails.Substring(0, 6);
            txtAccountNumber.Text = AStaff.PayeeDetails.Substring(6);
            txtHasPerms.Checked = AStaff.HasPerms;
            txtJoinDate.Text = AStaff.JoinDate.ToString("dd-mm-yyyy");
            txtExpiryDate.Text = AStaff.ContractExpiary.ToString("dd-mm-yyyy");
            error.InnerText = "";
        } else
        {
            // Display the error message, and clear old entry data (to avoid user confusion)
            error.InnerText = "Data entry not found";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtSortcode.Text = "";
            txtAccountNumber.Text = "";
            txtHasPerms.Checked = false;
            txtJoinDate.Text = "";
            txtExpiryDate.Text = "";
        }
    }
}