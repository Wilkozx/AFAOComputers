<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    body{
        background-color: Pink;
    }
    #BtnDelete, #btnAddProduct,#btnEdit,#BtnFilter, #BntclearFilter, #BtnDelete,#BtnReturn  {
       border-radius: 10px;
       background-color:deepskyblue;
       cursor: pointer;
      border-color:deepskyblue;
      
    }
    #btnAddProduct:hover, #BtnDelete:hover, #btnEdit:hover,#BtnFilter:hover, #BntclearFilter:hover, #BtnDelete:hover,#BtnReturn:hover{
        background-color:deepskyblue;
        box-shadow: gray 5px 5px 5px;
        border-color:dodgerblue;
        transition: 0.3s;
    }
     #form1 {
 margin: 0 auto;
 margin-top: 50px;
 grid-template-columns: 1fr 1fr 1fr;
 grid-template-rows: 1fr 1fr 1fr 1fr;
 background-color: aliceblue;
 border-radius: 25px;
 padding: 50px;
 align-items: center;
 box-shadow: gray 5px 5px 5px;
  
 }
    #LstProductList{
        border-radius: 10px;
        border-color: aliceblue;
        background-color:aliceblue;
        padding-left: 10px;
    }
</style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div style="height: 660px; width: 820px">
            <asp:ListBox ID="LstProductList" runat="server" Height="322px" Width="473px"></asp:ListBox>
            <asp:Button ID="btnAddProduct" runat="server" EnableTheming="True" OnClick="btnAddProduct_Click" style="z-index: 1; left: 60px; top: 460px; position: absolute; width: 96px;" Text="Add Product" height="26px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 252px; top: 459px; position: absolute; width: 96px" Text="Edit" height="26px" />
            <asp:Label ID="lblEnterName" runat="server" style="z-index: 1; left: 58px; top: 522px; position: absolute" Text="Enter a Product Name"></asp:Label>
            <asp:Label ID="LblError" runat="server" style="z-index: 1; left: 10px; top: 621px; position: absolute; width: 800px; height: 25px"></asp:Label>
            <asp:Button ID="BtnFilter" runat="server" OnClick="BtnFilter_Click" style="z-index: 1; left: 59px; top: 564px; position: absolute" Text="Apply Filter" height="32px" />
            <asp:Button ID="BntclearFilter" runat="server" OnClick="BntclearFilter_Click" style="z-index: 1; left: 199px; top: 562px; position: absolute; width: 124px; right: 814px; height: 32px;" Text="Clear Filter" />
            <asp:Button ID="BtnDelete" runat="server" height="26px" OnClick="BtnDelete_Click" style="z-index: 1; top: 459px; position: absolute; left: 435px" Text="Delete" width="96px"  />
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 248px; top: 517px; position: absolute; width: 193px"></asp:TextBox>
            <asp:Button ID="BtnReturn" runat="server" height="32px" OnClick="BtnReturn_Click" style="z-index: 1; top: 561px; position: absolute; left: 355px" Text="Return To Main Menu" />
        </div>
    </form>
</body>
</html>
