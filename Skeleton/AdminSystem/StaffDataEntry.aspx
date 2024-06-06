<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
    grid-template-rows: 1fr 1fr 1fr 1fr;
    grid-gap: 10px;
    width: 600px;
    background-color: aliceblue;
    border-radius: 25px;
    padding: 50px;
    align-items: center;
    box-shadow: gray 5px 5px 5px;
    }

    .input {
        border-radius: 5px;
        border: 1px solid #ccc;
        padding: 5px;
    }

    #bundleStaffId {
        display: grid;
        grid-row-start: 1;
        grid-column-start: 1;
    }

    #bundleFirstname {
        display: grid;
        grid-row-start: 2;
        grid-column-start: 1;
    }

    #bundleLastname {
        display: grid;
        grid-row-start: 2;
        grid-column-start: 2;
    }

    #bundleSortcode {
        display: grid;
        grid-row-start: 3;
        grid-column-start: 1;
    }

    #bundleAccountNumber {
        display: grid;
        grid-row-start: 3;
        grid-column-start: 2;
    }

    #bundleHasPerms {
        display: grid;
        grid-row-start: 1;
        grid-column-start: 3;
    }

    #bundleJoindate {
        display: grid;
        grid-row-start: 2;
        grid-column-start: 3;
    }

    #bundleExpirydate {
        display: grid;
        grid-row-start: 3;
        grid-column-start: 3;
    }

    #btnOk {
        display: grid;
        left: 50%;
        translate: -50%;
        grid-row-start: 4;
        grid-column-start: 2;
        width: 100px;
        height: 25px;
        text-align: center;
        border-radius: 5px;
    }


    #btnCancel {
        display: grid;
        left: 50%;
        translate: -50%;
        grid-row-start: 4;
        grid-column-start: 3;
        width: 100px;
        height: 25px;
        text-align: center;
        border-radius: 5px;
    }


    #btnFind {
        display: grid;
        left: auto;
        grid-row-start: 4;
        grid-column-start: 1;
        width: 100px;
        height: 25px;
        text-align: center;
        border-radius: 5px;
    }

    #btnMainMenu {
    display: grid;
    left: auto;
    grid-row-start: 5;
    grid-column-start: 2;
    height: 25px;
    text-align: center;
    border-radius: 5px;
    }

    #error {
        display: grid;
        grid-row-start: 6;
        grid-column-start: 1;
        grid-column-end: 5;
        color: red;
        text-align: center;
    }


        .auto-style1 {
            position: absolute;
            top: 268px;
            left: 677px;
        }


    </style>
</head>
<body style="height: 458px; margin-top: 15px;">
    this be the staff data entry yarrr
    <form id="form" runat="server" class="auto-style12">
        <div id="bundleStaffId">
            <label id="lblStaffId "for="txtStaffId">Staff Member ID</label>
            <asp:TextBox ID="txtStaffId" runat="server" CssId="txtStaffId" CssClass="input" style="z-index: 1"></asp:TextBox>
        </div>
        <div id="bundleFirstname">
            <label id="lblFirstname" for="txtFirstname">Firstname</label>
            <asp:TextBox ID="txtFirstname" runat="server" CssId="txtFirstname" CssClass="input" style="z-index: 1"></asp:TextBox>
        </div>
        <div id="bundleLastName">
            <label id="lblLastname" for="txtLastname">Lastname</label>
            <asp:TextBox ID="txtLastname" runat="server" CssId="txtLastname" CssClass="input" style="z-index: 1"></asp:TextBox>
        </div>
        <div id="bundleSortcode">
            <label id="lblSortcode" for="txtSortcode">Sortcode</label>
            <asp:TextBox ID="txtSortcode" runat="server" CssId="txtSortCode" CssClass="input" style="z-index: 1"></asp:TextBox>
        </div>
        <div id="bundleAccountNumber">
            <label id="lblAccountNumber" for="txtAccountNumber">Account Number</label>
            <asp:TextBox ID="txtAccountNumber" runat="server" CssId="txtAccountNumber" CssClass="input" style="z-index: 1"></asp:TextBox>
        </div>
        <div id="bundleHasPerms">
            <label id="lblHasPerms" for="txtHasPerms">Has Perms</label>
            <asp:Checkbox ID="txtHasPerms" runat="server" CssId="txtHasPerms" CssClass="input" style="z-index: 1"></asp:Checkbox>
        </div>
        <div id="bundleJoindate">
            <label id="lblJoinDate" for="txtJoinDate">Join Date</label>
            <asp:TextBox ID="txtJoinDate" runat="server" CssId="txtJoinDate" CssClass="input" style="z-index: 1"></asp:TextBox>
        </div>
        <div id="bundleExpirydate">
            <label id="lblExpiryDate" for="txtExpiryDate">Expiry Date</label>
            <asp:TextBox ID="txtExpiryDate" runat="server" CssId="txtExpiryDate" CssClass="input" style="z-index: 1"></asp:TextBox>
        </div>
        <asp:Button runat="server" id="btnOk" Text="ok" OnClick="btnOk_Click" />
        <asp:Button runat="server" id="btnCancel" Text="cancel" OnClick="btnCancel_Click1" />
        <asp:Button runat="server" ID="btnFind" Text="find" OnClick="btnFind_Click"/>
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" Text="Return To Main Menu" />
        <span runat="server" id="error"></span>
    </form>
</body>
</html>
