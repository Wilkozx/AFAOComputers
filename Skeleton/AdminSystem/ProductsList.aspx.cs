using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
       
     
 if (IsPostBack == false)
        {
            DisplayProducts(); 
        }
 //creating a new instance of clsProductAccount
 clsProductAccount AnAccount = new clsProductAccount();
        //getting data from the session object
        AnAccount = (clsProductAccount)Session["AnAccount"];
        //display the user name
        Response.Write("Logged in as:" + AnAccount.UserName);
    }
    void DisplayProducts()
    {
        clsProductCollection Products = new clsProductCollection(); 
        //setting the data source to list of products in the collect
        LstProductList.DataSource = Products.ProductList;
        //setting the name of the primary key
        LstProductList.DataValueField = "ProductId";
        //setting the datafield to dislay
        LstProductList.DataTextField = "Name";
        LstProductList.DataBind();
    }


    protected void btnAddProduct_Click(object sender, EventArgs e)
    {
        Session["ProductId"] = -1;
        //redirecting 
        Response.Redirect("ProductsDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key
        Int32 ProductId;
        //if a record has been selected from the list
        if(LstProductList.SelectedIndex != -1)
        {
            //getting the primary key value to edit
            ProductId = Convert.ToInt32(LstProductList.SelectedValue);
            //store the data in session object
            Session["ProductId"] = ProductId;
            Response.Redirect("ProductsDataEntry.aspx");
        }
        else
        {
            LblError.Text = "Pleass select a product from the list to edith";
        }
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductId;
        //if statement when the record is selected
        if (LstProductList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            ProductId = Convert.ToInt32(LstProductList.SelectedValue);
            //store the selected data
            Session["ProductId"] = ProductId;
            //redirect to the delete page
            Response.Redirect("ProductsConfirmDelete.aspx");
        }
        else //if no record has been selected 
        {
            //Display the error message
            LblError.Text = "Please select the Product from the list to delete: ";
        }
    }

    protected void BtnFilter_Click(object sender, EventArgs e)
    {
        //creating an instance of the address object
        clsProductCollection AProduct = new clsProductCollection(); 
        //retrieve the value of the post code from the pressentation layer
        AProduct.ReportByName(txtFilter.Text);
        //setting the data source to the list of addresses in the collection
        LstProductList.DataSource = AProduct.ProductList;
        //Set the name of the field to display
        LstProductList.DataTextField = "Name";
        //bind the data to the list
        LstProductList.DataBind();
    }

    protected void BntclearFilter_Click(object sender, EventArgs e)
    {
        clsProductCollection AProduct = new clsProductCollection();
        //set an empty string
        AProduct.ReportByName("");
        //CLEARING 
        txtFilter.Text = "";
        //setting the data source to the list of products in the collection
        LstProductList.DataSource= AProduct.ProductList;
        LstProductList.DataValueField = "ProductId";
        LstProductList.DataValueField = "Name";
        LstProductList.DataBind();
    }

    protected void BtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}