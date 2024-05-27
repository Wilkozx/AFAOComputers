using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        // create an instance of the Staff Collection
        clsStaffCollection StaffCollection = new clsStaffCollection();
        // set the data source to the list of the staff in the collection 
        lstStaffList.DataSource = StaffCollection.StaffList;
        // set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        // set the data field to display
        lstStaffList.DataTextField = "Firstname";
        // bind the data to the list
        lstStaffList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        // redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        Int32 StaffId;
        // if a recored has been sellected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            // get the primary key of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            // store the data in the session object
            Session["StaffId"] = StaffId;
            // redirect to edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key of the record to be deleted
        Int32 StaffId;
        // if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1 )
        {
            // get the primary key value of the record delete
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            // store the data in the session object
            Session["StaffId"] = StaffId;
            // redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            // display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}