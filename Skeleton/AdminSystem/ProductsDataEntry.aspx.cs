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
            AProduct.ProductId = ProductId;
            AProduct.Name = Name;
            AProduct.Description = Description;
            AProduct.Price = Price;
            AProduct.SKU = Convert.ToInt32(txtSKU.Text);
            AProduct.DateAdded = Convert.ToDateTime(Date_Added);
            AProduct.Visible = chkVisible.Checked;
            //Creating a new instance of the address collection
            clsProductCollection ProductList = new clsProductCollection();
            //if this is a new record ie Product id
            if (ProductId == -1)
            {
                ProductList.ThisProduct = AProduct;
                //adding
                ProductList.Add();
            }
            //otherwise it must be updated
            else
            {
                ProductList.ThisProduct.Find(ProductId);
                //Setting this property
                ProductList.ThisProduct = AProduct;
                //update
                ProductList.Update();
            }
            
           
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
        
        //find the record
        Found = AProduct.Find(AProduct.ProductId);
        if (TxtProductId.Text != "")
        {
            ProductId = Convert.ToInt32(TxtProductId.Text);
            Found = AProduct.Find(ProductId);
        }
        //I found
        if (Found == true)

        { //Displaying the values of the properties in the form
            TxtProductId.Text = AProduct.ProductId.ToString();
            txtName.Text = AProduct.Name;
            txtDescription.Text = AProduct.Description;
            TxtPrice.Text = AProduct.Price.ToString();
            TxtDateAdded.Text = AProduct.DateAdded.ToString();
            txtSKU.Text = AProduct.SKU.ToString();
            chkVisible.Checked = AProduct.Visible;

        }
        else
        {
            lblError.Text = "Please Enter a product Id to find";
        }
    }

    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the product to be proccessed
        ProductId = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (ProductId != -1)
            {

                DisplayProduct();
            }else
            {
                TxtProductId.Text = "";
                TxtProductId.Enabled = false;
                BtnFind.Enabled = false;
            }
        }
    }
    void DisplayProduct()
    {
        clsProductCollection Products = new clsProductCollection();
        //find the record to update
        Products.ThisProduct.Find(ProductId);
        //display th data for the record
        txtDescription.Text = Products.ThisProduct.Description.ToString();  
        TxtProductId.Text = Products.ThisProduct.ProductId.ToString();  
        txtName.Text = Products.ThisProduct.Name.ToString();
        txtSKU.Text = Products.ThisProduct.SKU.ToString();
        TxtDateAdded.Text = Products.ThisProduct.DateAdded.ToString();
        TxtPrice.Text = Products.ThisProduct.Price.ToString();  
        chkVisible.Checked = Products.ThisProduct.Visible;
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductsList.aspx");
    }
}