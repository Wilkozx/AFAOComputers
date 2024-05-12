using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //create a new instance of a clsProduct
        clsProduct AProduct = new clsProduct();

        //capture the name
        AProduct.Name = txtName.Text;
        //capture the description
        AProduct.Description = txtDescription.Text;
        //capture the product ID
        AProduct.ProductId = Convert.ToInt32(TxtProductId.Text);
        //Capture the SKU
        AProduct.SKU = Convert.ToInt32(txtSKU.Text);
        //Capture the sku
        AProduct.DateAdded = Convert.ToDateTime(DateTime.Now);
        //Capture the Price
        AProduct.Price = TxtPrice.Text;
        //Capture the Visibility
        AProduct.Visible = chkVisible.Checked;
        //store the Product in the session object;
        Session["AProduct"] = AProduct;
        //navigate to the view page
        Response.Redirect("ProductsViewer.aspx");
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
}