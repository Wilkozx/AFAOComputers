using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        string Name = txtName.Text;
        string Description = txtDescription.Text;
        string Price = TxtPrice.Text;
        string Date_Added = TxtDateAdded.Text;
        string sKU = txtSKU.Text;
        AProduct.Visible = chkVisible.Checked;
        
        string Error = "";
        //Vallidating the entered Data
        Error = AProduct.Valid(Name, Description, sKU, Date_Added, Price);
        if (Error == "")
        {
            //CAPTURING THE DETAILS
            AProduct.Name = Name;
            AProduct.Description = Description;
            AProduct.Price = Price;
            AProduct.SKU= Convert.ToInt32(txtSKU.Text);
            AProduct.DateAdded = Convert.ToDateTime(Date_Added);
            AProduct.Visible= chkVisible.Checked;
            //Creating a new instance of the address collection
            clsProductCollection ProductList = new clsProductCollection();
            //set the thisProduct property
            ProductList.ThisProduct = AProduct;
            ProductList.Add();
            //navigate to the view page
            Response.Redirect("ProductsList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void BtnFind_Click(object sender, EventArgs e)
    {
        //creating an instance of address class
        clsProduct AProduct = new clsProduct();
        //creating variable to store the primary key
        Int32 ProductId;
        //creating variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ProductId = Convert.ToInt32(TxtProductId.Text);
        //find the record
        Found = AProduct.Find(ProductId);
        //I found
        if(Found ==true)

        { //Displaying the values of the properties in the form
            TxtProductId.Text = AProduct.ProductId.ToString();
            txtName.Text = AProduct.Name;
            txtDescription.Text = AProduct.Description;
            TxtPrice.Text = AProduct.Price.ToString();
            TxtDateAdded.Text= AProduct.DateAdded.ToString();
            txtSKU.Text = AProduct.SKU.ToString();
            chkVisible.Checked = AProduct.Visible;
          
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }
}