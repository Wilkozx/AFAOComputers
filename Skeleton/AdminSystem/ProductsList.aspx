<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 514px; width: 820px">
            <asp:ListBox ID="LstProductList" runat="server" Height="412px" Width="525px"></asp:ListBox>
            <asp:Button ID="btnAddProduct" runat="server" EnableTheming="False" OnClick="btnAddProduct_Click" style="z-index: 1; left: 10px; top: 460px; position: absolute" Text="Add Product" />
        </div>
    </form>
</body>
</html>
