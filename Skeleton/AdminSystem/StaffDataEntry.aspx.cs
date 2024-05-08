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
}