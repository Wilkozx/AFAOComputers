<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 660px; width: 820px">
            <asp:ListBox ID="LstProductList" runat="server" Height="412px" Width="473px"></asp:ListBox>
            <asp:Button ID="btnAddProduct" runat="server" EnableTheming="True" OnClick="btnAddProduct_Click" style="z-index: 1; left: 10px; top: 460px; position: absolute; width: 96px;" Text="Add Product" height="26px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 153px; top: 459px; position: absolute; width: 96px" Text="Edit" height="26px" />
            <asp:Label ID="lblEnterName" runat="server" style="z-index: 1; left: 10px; top: 522px; position: absolute" Text="Enter a Product Name"></asp:Label>
            <asp:Label ID="LblError" runat="server" style="z-index: 1; left: 10px; top: 621px; position: absolute; width: 800px; height: 25px"></asp:Label>
            <asp:Button ID="BtnFilter" runat="server" OnClick="BtnFilter_Click" style="z-index: 1; left: 55px; top: 559px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="BntclearFilter" runat="server" height="26px" OnClick="BntclearFilter_Click" style="z-index: 1; left: 188px; top: 557px; position: absolute; bottom: 105px; width: 100px" Text="Clear Filter" />
            <asp:Button ID="BtnDelete" runat="server" height="26px" OnClick="BtnDelete_Click" style="z-index: 1; top: 459px; position: absolute; left: 321px" Text="Delete" width="96px" />
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 154px; top: 517px; position: absolute; width: 193px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
