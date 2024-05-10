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
//create a new instance of clsProduct
clsProduct AProduct = new clsProduct();
        //get the data from the session object
        AProduct = (clsProduct)Session["AProduct"];
        //display the Product name for this entry
        Response.Write(AProduct.Name + "<br>" );
        //display the Descriotion
        Response.Write(AProduct.Description +"<br>");
        //display the Price
        Response.Write(AProduct.Price + "<br>");
        //display the Product ID
        Response.Write(AProduct.ProductId + "<br>");
        //display the SKU
        Response.Write(AProduct.SKU + "<br>");
        //display the Descriotion the Date Added
        Response.Write(AProduct.DateAdded + "<br>");
        //display the Visibility
        Response.Write(AProduct.Visible + "<br>");
    }
}