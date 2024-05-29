<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<style>

</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <asp:Button runat="server" Text="Add" OnClick="btnAdd_Click" ID="btnAdd"></asp:Button>
        <div>
        <asp:ListBox ID="lstUserList" runat="server"></asp:ListBox>
        </div>
        <p>
        <asp:Button runat="server" Text="Edit" OnClick="btnEdit_Click" ID="btnEdit"></asp:Button>
        </p>
    </form>

</body>
</html>
