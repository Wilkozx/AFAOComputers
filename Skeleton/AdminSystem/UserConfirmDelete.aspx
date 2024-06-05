<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 43px; top: 75px; position: absolute; width: 47px;" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; top: 75px; position: absolute; left: 161px; margin-top: 0px; width: 50px;" Text="No" OnClick="btnNo_Click" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
