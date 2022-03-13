<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="basic_elements.Sample.Calendar.Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="TextBox1" runat="server" Width="115px"></asp:TextBox>
            <asp:ImageButton ID="ImageButton1" runat="server"
                ImageUrl="~/Assets/Images/Calendar.png" OnClick="ImageButton1_Click" />

            <asp:ImageButton ID="ImageButton2" runat="server"
                ImageUrl="~/Assets/Images/Calendar.png" OnClick="ImageButton2_Click" />
            <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender"
                OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>

            <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged" OnDayRender="Calendar2_DayRender" OnVisibleMonthChanged="Calendar2_VisibleMonthChanged"></asp:Calendar>

        </div>
    </form>
</body>
</html>
