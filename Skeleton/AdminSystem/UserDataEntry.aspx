<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
&nbsp;
        <asp:TextBox ID="txtUserId" runat="server" style="z-index: 1; left: 172px; top: 34px; position: absolute; width: 126px"></asp:TextBox>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 10px; top: 77px; position: absolute" Text="UserName" width="87px"></asp:Label>
        <asp:Label ID="lblUserId" runat="server" style="z-index: 1; left: 9px; top: 34px; position: absolute; width: 87px; bottom: 623px" Text="UserId"></asp:Label>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 320px; top: 52px; position: absolute; height: 27px; width: 60px; margin-top: 4px; margin-bottom: 135px;" Text="Find" />
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 9px; top: 110px; position: absolute; width: 87px; margin-bottom: 0px" Text="Email"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 172px; top: 73px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 9px; top: 148px; position: absolute; width: 87px" Text="Password"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblDateofBirth" runat="server" style="z-index: 1; left: 9px; top: 184px; position: absolute" Text="DateofBirth" width="87px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 172px; top: 142px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 172px; top: 223px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtDateofBirth" runat="server" style="z-index: 1; left: 172px; top: 180px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkboxStaff" runat="server" style="z-index: 1; left: 97px; top: 259px; position: absolute" Text="isStaff" />
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 9px; top: 224px; position: absolute; height: 15px; width: 87px" Text="PhoneNumber"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 172px; top: 107px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 154px; top: 296px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 250px; top: 296px; position: absolute" Text="Return to main menu" />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 46px; top: 296px; position: absolute; width: 54px" Text="Ok" />
        <p>
            &nbsp;</p>
        <asp:Label ID="ERROR" runat="server" style="z-index: 1; left: 450px; top: 224px; position: absolute; height: 15px; width: 150px"></asp:Label>
        

        
    </form>
</body>
</html>
