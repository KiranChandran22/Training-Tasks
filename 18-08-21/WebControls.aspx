<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="mvz1.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" style="margin-left: 664px" Text="Click Me" Width="154px" />
            <br />
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Messi</asp:ListItem>
                <asp:ListItem>Ronaldo</asp:ListItem>
                <asp:ListItem>Neymar</asp:ListItem>
                <asp:ListItem>Ramos</asp:ListItem>
                <asp:ListItem>Virgil</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
