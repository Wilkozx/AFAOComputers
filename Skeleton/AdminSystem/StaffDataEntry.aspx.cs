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
        AStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        AStaff.FirstName = txtFirstname.Text;
        AStaff.LastName = txtLastname.Text;
        AStaff.HasPerms = txtHasPerms.Checked;
        AStaff.PayeeDetails = txtSortcode.Text + " " + txtAccountNumber.Text;
        AStaff.JoinDate = Convert.ToDateTime(txtJoinDate.Text);
        AStaff.ContractExpiary = Convert.ToDateTime(txtExpiryDate.Text);
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
            txtSortcode.Text = AStaff.PayeeDetails.Substring(0, 4);
            txtAccountNumber.Text = AStaff.PayeeDetails.Substring(4);
            txtHasPerms.Checked = AStaff.HasPerms;
            txtJoinDate.Text = AStaff.JoinDate.ToString("dd-mm-yyyy");
            txtExpiryDate.Text = AStaff.ContractExpiary.ToString("dd-mm-yyyy");
        }
    }
}