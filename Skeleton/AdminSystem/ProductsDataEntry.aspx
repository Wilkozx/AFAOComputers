﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <style>
    body{
        background-color: Pink;
    }
   
     #form1 {
 margin: 0 auto;
 margin-top: 50px;
 grid-template-columns: 1fr 1fr 1fr;
 grid-template-rows: 1fr 1fr 1fr 1fr;
 background-color: aliceblue;
 border-radius: 25px;
 padding: 50px;
 align-items: center;
 box-shadow: gray 5px 5px 5px;
  
 }
     #btnOk, #BtnFind, #btnReturn, #btnCancel{
          border-radius: 10px;
 background-color:deepskyblue;
 cursor: pointer;
border-color:deepskyblue;
     }
     #btnOk:hover, #BtnFind:hover, #btnReturn:hover, #btnCancel:hover{
          background-color:deepskyblue;
 box-shadow: gray 5px 5px 5px;
 border-color:dodgerblue;
 transition: 0.3s;
     }
    
</style>
</head>
<body style="height: 271px">
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:TextBox ID="TxtProductId" runat="server" style="z-index: 1; left: 299px; top: 89px; position: absolute; height: 20px; width: 160px"></asp:TextBox>
                <asp:Button ID="btnOk" runat="server" height="28px" OnClick="btnOk_Click" style="z-index: 1; left: 136px; top: 442px; position: absolute; width: 88px; right: 1261px;" Text="OK" />
            </p>
        </div>
        <p style="width: 1440px; height: 303px">
            <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 147px; top: 136px; position: absolute; " Text="Description" height="18px" width="99px"></asp:Label>
                <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 299px; top: 131px; position: absolute; width: 160px" height="20px"></asp:TextBox>
            <asp:TextBox ID="txtSKU" runat="server" height="20px" style="z-index: 1; left: 299px; top: 267px; position: absolute; width: 160px"></asp:TextBox>
            <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" style="z-index: 1; left: 574px; top: 90px; position: absolute; width: 84px; height: 36px" Text="Find" />
            <asp:Button ID="btnReturn" runat="server" height="28px" OnClick="btnReturn_Click" style="z-index: 1; left: 410px; top: 438px; position: absolute; width: 176px;" Text="Return To The Main Menu" />
        </p>
        <p style="height: 38px">
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 147px; top: 178px; position: absolute; width: 99px; height: 18px" Text="Price"></asp:Label>
            <asp:TextBox ID="TxtPrice" runat="server" style="z-index: 1; left: 299px; top: 172px; position: absolute; width: 160px; height: 20px; bottom: 498px"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 147px; top: 232px; position: absolute; height: 18px; width: 99px" Text="Product Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 299px; top: 219px; position: absolute; width: 160px; height: 20px"></asp:TextBox>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 268px; top: 440px; position: absolute; width: 88px; height: 28px;" Text="CANCEL" OnClick="btnCancel_Click" />
        </p>
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 147px; top: 92px; position: absolute; bottom: 586px" Text="Product ID" height="18px" width="99px"></asp:Label>
        <p style="margin-top: 13px">
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblSKU" runat="server" style="z-index: 1; left: 147px; top: 273px; position: absolute; width: 99px; height: 22px;" Text="SKU"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 147px; top: 319px; position: absolute" Text="Date Added" width="99px"></asp:Label>
            <asp:TextBox ID="TxtDateAdded" runat="server" style="z-index: 1; left: 299px; top: 316px; position: absolute; width: 160px" height="20px"></asp:TextBox>
            <asp:CheckBox ID="chkVisible" runat="server" style="z-index: 1; left: 271px; top: 372px; position: absolute; width: 160px; height: 20px" Text="Visible" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 147px; top: 407px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
