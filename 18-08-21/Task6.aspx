<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task6.aspx.cs" Inherits="mvz1.Task6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Height="111px" Width="138px" >
                <asp:ListItem>Cookie</asp:ListItem>
                <asp:ListItem>Cake</asp:ListItem>
                <asp:ListItem>Bread</asp:ListItem>
                <asp:ListItem>Bun</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="For Image Press here" Width="241px" />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="160px" Width="219px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Press here to check Price" Width="252px" />
            <br />
            <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <br />
            <br />
            Enter the Quantity:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Literal ID="Literal2" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
