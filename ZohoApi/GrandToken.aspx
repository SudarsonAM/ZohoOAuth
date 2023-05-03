<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="GrandToken.aspx.cs" Inherits="ZohoApi.GrandToken" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="ans1" runat="server" Text="none"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Get Grand Token" OnClick="GetToken"/>
        <br />
        <asp:Label ID="ans2" runat="server" Text="none"></asp:Label>
        <br />
        <br />
        
        <asp:Label ID="ans3" runat="server" Text="none"></asp:Label>
    </form>
    
</body>
</html>
