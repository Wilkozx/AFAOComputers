<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 418px; width: 1188px">
            <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 211px; top: 86px; position: absolute; width: 311px">Are You Sure you want to Delete this Product ?</asp:Label>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 259px; top: 154px; position: absolute; width: 55px; height: 29px" Text="Yes" />
            <asp:Button ID="BntNo" runat="server" height="29px" OnClick="BntNo_Click" style="z-index: 1; left: 383px; top: 153px; position: absolute" Text="No" width="55px" />
        </div>
    </form>
</body>
</html>
