<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication1.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Different Food types<br />
            <br />
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="115px" Width="175px">
            <asp:ListItem>Breakfast</asp:ListItem>
            <asp:ListItem>Lunch</asp:ListItem>
            <asp:ListItem>Snacks</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="43px" OnClick="Button1_Click" style="margin-left: 168px" Text="Button" Width="167px" />
    </form>
</body>
</html>
