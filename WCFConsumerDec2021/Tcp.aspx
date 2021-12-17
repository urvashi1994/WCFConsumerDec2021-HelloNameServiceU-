<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tcp.aspx.cs" Inherits="WCFConsumerDec2021.Tcp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="textName" runat="server"></asp:TextBox>
            <asp:Button ID="buttonSubmit" runat="server" Text="Submit" OnClick="buttonSubmit_Click" />
        </div>
        <div>
            <asp:Label ID="labelResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
