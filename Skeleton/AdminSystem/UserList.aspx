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
        <div>
        <asp:ListBox ID="lstUserList" runat="server" Height="232px" Width="505px"></asp:ListBox>
        <asp:Button runat="server" Text="Add" OnClick="btnAdd_Click" ID="btnAdd" style="margin-top: 0px"></asp:Button>
        <asp:Button runat="server" Text="Edit" OnClick="btnEdit_Click" ID="btnEdit"></asp:Button>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </div>
        <p>
            <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 53px; top: 283px; position: absolute; height: 20px; width: 150px" Text="Enter a UserName"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 215px; top: 282px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 87px; top: 324px; position: absolute; height: 34px" Text="Apply Filter" OnClick="btnApply_Click" />
            <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 219px; top: 323px; position: absolute; height: 36px; width: 107px;" Text="Clear Filter" OnClick="btnClear_Click" />
        </p>
        <asp:Label ID="lblError2" runat="server" style="z-index: 1; left: 104px; top: 377px; position: absolute" Text="lblError"></asp:Label>
    </form>

</body>
</html>
