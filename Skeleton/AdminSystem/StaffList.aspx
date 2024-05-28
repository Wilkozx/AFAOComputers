<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 39px;
            left: 140px;
            z-index: 1;
            width: 502px;
            height: 449px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:ListBox ID="lstStaffList" runat="server" CssClass="auto-style1"></asp:ListBox>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblEnterName" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtFilterInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" />
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" Text="Return To Main Menu" />
    </form>
</body>
</html>
