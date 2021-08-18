<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task8.aspx.cs" Inherits="mvz1.Task8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" BorderStyle="Inset" BorderWidth="10px" CellPadding="1" CellSpacing="4" FirstDayOfWeek="Saturday" Height="300px" NextPrevFormat="FullMonth" Width="500px">
                <DayStyle BackColor="#996633" />
                <NextPrevStyle BackColor="White" />
                <OtherMonthDayStyle BackColor="#CCCCCC" />
                <SelectedDayStyle BackColor="#33CCFF" />
                <SelectorStyle BackColor="Lime" ForeColor="Black" />
                <TitleStyle BackColor="#009933" Font-Bold="True" ForeColor="White" />
                <TodayDayStyle BackColor="#0066CC" Font-Bold="True" />
            </asp:Calendar>
        </div>
    </form>
</body>
</html>
