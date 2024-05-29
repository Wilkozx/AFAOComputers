<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:ListBox ID="lstUserList" runat="server"></asp:ListBox>
        <asp:Button runat="server" Text="Button" OnClick="btnAdd_Click" ID="btnAdd"></asp:Button>
        <asp:Button runat="server" Text="Button" OnClick="btnEdit_Click" ID="btnEdit"></asp:Button>
         <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 200px; top: 70px; position: absolute" Text="lblError"></asp:Label>
        <div>
        </div>
    </form>
</body>
</html>
