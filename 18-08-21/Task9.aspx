<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task9.aspx.cs" Inherits="mvz1.Task9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server"><a href="www.amazon.in"</a>
                <asp:Image ID="Image1" src="ama.jfif" runat="server" height="400px" width="90%" /></asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server"><a href="www.fabindia.com"</a>
                <asp:Image ID="Image2" src="fab.png" runat="server" height="400px" width="90%"  />
            </asp:HyperLink>
        </div>
    </form>
</body>
</html>
