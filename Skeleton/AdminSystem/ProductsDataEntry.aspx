<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 386px;
        }
    </style>
</head>
<body style="height: 271px">
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:TextBox ID="TxtProductId" runat="server" style="z-index: 1; left: 134px; top: 46px; position: absolute; height: 20px; width: 160px"></asp:TextBox>
            </p>
        </div>
        <p style="width: 1440px; height: 303px">
            <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 8px; top: 91px; position: absolute; " Text="Description" height="18px" width="99px"></asp:Label>
                <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 134px; top: 94px; position: absolute; width: 160px" height="20px"></asp:TextBox>
            <asp:Button ID="BtnAdd" runat="server" Height="29px" OnClick="BtnAdd_Click" style="margin-left: 53px; margin-top: 334px;" Text="Add Product" Width="99px" />
            <asp:Button ID="BtnCancel" runat="server" Height="29px" style="margin-left: 37px" Text="Cancel" Width="99px" />
            <asp:TextBox ID="txtSKU" runat="server" height="20px" style="z-index: 1; left: 134px; top: 216px; position: absolute; width: 160px"></asp:TextBox>
        </p>
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 6px; top: 51px; position: absolute; bottom: 607px" Text="Product ID" height="18px" width="99px"></asp:Label>
        <p style="height: 38px">
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 8px; top: 135px; position: absolute; width: 99px; height: 18px" Text="Price"></asp:Label>
            <asp:TextBox ID="TxtPrice" runat="server" style="z-index: 1; left: 134px; top: 135px; position: absolute; width: 160px; height: 20px; bottom: 604px"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 8px; top: 176px; position: absolute; height: 18px; width: 99px" Text="Product Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 134px; top: 180px; position: absolute; width: 160px; height: 20px"></asp:TextBox>
        </p>
        <p style="margin-top: 13px">
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblSKU" runat="server" style="z-index: 1; left: 8px; top: 211px; position: absolute; width: 99px; " Text="SKU" height="18px"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 10px; top: 250px; position: absolute" Text="Date Added" width="99px"></asp:Label>
            <asp:TextBox ID="TxtDateAdded" runat="server" style="z-index: 1; left: 134px; top: 250px; position: absolute; width: 160px" height="20px"></asp:TextBox>
            <asp:CheckBox ID="chkVisible" runat="server" style="z-index: 1; left: 129px; top: 292px; position: absolute; width: 160px; height: 20px" Text="Visible" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 328px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
