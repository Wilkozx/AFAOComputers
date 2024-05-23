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
            <asp:Button ID="btnAddProduct" runat="server" EnableTheming="True" OnClick="btnAddProduct_Click" style="z-index: 1; left: 10px; top: 460px; position: absolute; width: 96px;" Text="Add Product" height="26px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 153px; top: 459px; position: absolute; width: 96px" Text="Edit" height="26px" />
            <asp:Label ID="LblError" runat="server" style="z-index: 1; left: 10px; top: 496px; position: absolute; width: 760px; height: 24px"></asp:Label>
            <asp:Button ID="BtnDelete" runat="server" height="26px" OnClick="BtnDelete_Click" style="z-index: 1; top: 459px; position: absolute; left: 313px" Text="Delete" width="96px" />
        </div>
    </form>
</body>
</html>
