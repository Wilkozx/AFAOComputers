using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the address to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (StaffId != -1)
            {
                // display the current data for the record
                DisplayAddress();
            }
        }
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
            // capture the staff id
            AStaff.StaffId = StaffId;
            // capture the firstname
            AStaff.FirstName = Firstname;
            // capture the lastname
            AStaff.LastName = Lastname;
            // capture the has perms 
            AStaff.HasPerms = Convert.ToBoolean(hasPerms);
            // capture and hash the payee details
            String unhashedPayeeDetails = sortCode + accountNumber;
            AStaff.PayeeDetails = unhashedPayeeDetails;
            // capture the join date
            AStaff.JoinDate = Convert.ToDateTime(joinDate);
            // capture the contract expiry
            AStaff.ContractExpiary = Convert.ToDateTime(contractExpiry);
            // create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            // if this is a new record i.e staff id -1 then we add
            if (StaffId == -1)
            {
                // set the thisStaff property
                StaffList.ThisStaff = AStaff;
                // add the new record
                StaffList.Add();
            }
            // otherwise it might be an update
            else
            {
                // find the record to update
                StaffList.ThisStaff.Find(StaffId);
                // set the thisStaff property
                StaffList.ThisStaff = AStaff;
                // update the record
                StaffList.Update();
            }
            // redirect back to the list pages
            Response.Redirect("StaffList.aspx");
        } 
        else
        {
            // display the error message
            error.InnerText = Error;
        }

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

    void DisplayAddress()
    {
        // create an instance of the staff collection
        clsStaffCollection StaffList = new clsStaffCollection();
        // find the record to update
        StaffList.ThisStaff.Find(StaffId);
        // display the data for the record
        txtStaffId.Text = StaffList.ThisStaff.StaffId.ToString();
        txtFirstname.Text = StaffList.ThisStaff.FirstName.ToString();
        txtLastname.Text = StaffList.ThisStaff.LastName.ToString();
        txtSortcode.Text = StaffList.ThisStaff.PayeeDetails.Substring(0, 6);
        txtAccountNumber.Text = StaffList.ThisStaff.PayeeDetails.Substring(6);
        txtHasPerms.Checked = StaffList.ThisStaff.HasPerms;
        txtJoinDate.Text = StaffList.ThisStaff.JoinDate.ToString();
        txtExpiryDate.Text = StaffList.ThisStaff.ContractExpiary.ToString();
    }
}