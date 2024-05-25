<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsLogin.aspx.cs" Inherits="ProductsLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 617px">
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 110px; top: 124px; position: absolute" Text="UserName"></asp:Label>
            <asp:Label ID="LblPassWord" runat="server" style="z-index: 1; left: 108px; top: 175px; position: absolute" Text="PassWord"></asp:Label>
            <asp:TextBox ID="TxtUserName" runat="server" style="z-index: 1; left: 206px; top: 122px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPassWord" runat="server" style="z-index: 1; left: 204px; top: 177px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 389px; top: 148px; position: absolute"></asp:Label>
            <asp:Button ID="btnLogin" runat="server" height="29px" OnClick="btnLogin_Click" style="z-index: 1; left: 165px; top: 245px; position: absolute" Text="Login" width="77px" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 290px; top: 245px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Image ID="ImgLogo" runat="server" ImageUrl="~/AfaoLogo.png" style="z-index: 1; left: 110px; top: 15px; position: absolute; width: 420px; height: 69px" />
        </div>
    </form>
</body>
</html>
