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

}