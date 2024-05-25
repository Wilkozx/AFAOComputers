<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 770px">
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" style="z-index: 1; left: 307px; top: 72px; position: absolute; width: 507px; height: 53px" Text="Afao Computers Main Menu"></asp:Label>
            <asp:Button ID="BtnProducts" runat="server" OnClick="BtnProducts_Click" style="z-index: 1; left: 241px; top: 202px; position: absolute; height: 37px; width: 111px" Text="Products" />
            <asp:Button ID="BtnStaff" runat="server" height="37px" OnClick="BtnStaff_Click" style="z-index: 1; left: 409px; top: 202px; position: absolute" Text="Staffs" width="111px" />
            <asp:Button ID="BtnUsers" runat="server" height="37px" OnClick="BtnUsers_Click" style="z-index: 1; left: 566px; top: 202px; position: absolute" Text="Users" width="111px" />
            <asp:Button ID="BtnOrders" runat="server" height="37px" OnClick="BtnOrders_Click" style="z-index: 1; left: 729px; top: 202px; position: absolute" Text="Orders" width="111px" />
            <asp:Image ID="imgLogo" runat="server" ImageUrl="~/AfaoLogo.png" style="z-index: 1; left: 210px; top: 318px; position: absolute; width: 682px" />
        </div>
    </form>
</body>
</html>
