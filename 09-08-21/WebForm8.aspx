<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication1.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h3>Select the Metal, that u need information</h3><br />
            <br />

            <asp:DropDownList ID="DropDownList1" runat="server" >
            </asp:DropDownList>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" Width="187px" />
            <br />
            <br />
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />
            <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>

        </div>
    </form>
</body>
</html>
