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
}