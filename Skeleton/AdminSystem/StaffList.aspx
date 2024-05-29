<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form {
        margin: 0 auto;
        margin-top: 50px;
        display: grid;
        grid-template-columns: 1fr 1fr 1fr;
        grid-template-rows: 1fr 1fr 1fr;
        grid-gap: 10px;
        width: 600px;
        background-color: aliceblue;
        border-radius: 25px;
        padding: 50px;
        align-items: center;
        box-shadow: gray 5px 5px 5px;
        height: 600px;
        }

        .input {
            border-radius: 5px;
            border: 1px solid #ccc;
            padding: 5px;
        }

        #lstStaffList {
            display: grid;
            grid-column-start: 1;
            grid-row-start: 1;
            grid-row-end: 1;
            grid-column-end: 4;
            height: 400px
        }

        #Filterbundle {
            display: grid;
            grid-column-start: 2;
            grid-row-start: 2;
        }

        #Filteritems {
            display: flex;
            flex-direction: row;
        }

        #Modifybundle {
            display: grid;
            grid-column-start: 3;
            grid-row-start: 1;
        }

    </style>
</head>
<body>
    <form id="form" runat="server">
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" Text="Return To Main Menu" />
        <asp:ListBox ID="lstStaffList" runat="server" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged"></asp:ListBox>
        <div id="Filterbundle">
            <div id="Filteritems">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="txtFilterInput" runat="server"></asp:TextBox>
                <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
                <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" />
            </div>
        </div>
        <div id="Mofifybundle">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </div>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
