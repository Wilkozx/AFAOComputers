using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsProductCollection ProductList = new clsProductCollection();
        ProductList.ThisProduct.Find(ProductId);
        //Deleting
        ProductList.Delete();
        //redirecting back to the list page
        Response.Redirect("ProductsList.aspx");

    }

    protected void BntNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductsList.aspx");
    }
}

