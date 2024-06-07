<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
    User Login Page</p>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" Width="131px"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
    
    
</body>
</html>
