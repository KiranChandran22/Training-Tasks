<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="mvz1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Course FeedBack Form</h3>
            <p>&nbsp;</p>
            <p>Student Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p>&nbsp;Sex:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="27px" style="margin-left: 65px; margin-top: 0px" Width="96px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p>&nbsp;</p>
            <p>Select Course:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Width="205px">
                    <asp:ListItem>DotNet</asp:ListItem>
                    <asp:ListItem>Devops</asp:ListItem>
                    <asp:ListItem>Data Exploration</asp:ListItem>
                    <asp:ListItem>Big Data</asp:ListItem>
                    <asp:ListItem>Web Development</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>&nbsp;</p>
            <p>Technical Coverage:<asp:RadioButtonList ID="RadioButtonList2" runat="server">
                <asp:ListItem>Excellent</asp:ListItem>
                <asp:ListItem>Good</asp:ListItem>
                <asp:ListItem>Average </asp:ListItem>
                <asp:ListItem>Poor</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p>&nbsp;</p>
            <p>Suggestions:</p>
            <p><asp:TextBox ID="TextBox2" runat="server" Height="58px" Width="428px" ></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 154px" Text="Submit" Width="201px" />
            </p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
        </div>
    </form>
</body>
</html>
