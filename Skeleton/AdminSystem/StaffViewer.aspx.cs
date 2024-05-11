using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        AStaff = (clsStaff)Session["AStaff"];
        Response.Write("StaffId: " + AStaff.StaffId);
        Response.Write(" Firstname: " + AStaff.FirstName); 
        Response.Write(" Lastname: " + AStaff.LastName);
        Response.Write(" HasPerms: " + AStaff.HasPerms);
        Response.Write(" PayeeDetails: " + AStaff.PayeeDetails);
        Response.Write(" Join Date: " + AStaff.JoinDate);
        Response.Write(" Contract Expiry: " + AStaff.ContractExpiary);
    }
}