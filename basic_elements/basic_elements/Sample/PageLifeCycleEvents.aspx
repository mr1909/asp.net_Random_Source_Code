<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageLifeCycleEvents.aspx.cs" Inherits="basic_elements.Sample.PageLifeCycleEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>

<%--
    
     http://csharp-video-tutorials.blogspot.com/2012/10/aspnet-page-life-cycle-events-part-6.html
     https://csharp-video-tutorials.blogspot.com/2012/10/aspnet-server-control-events-part-7.html

     --%>


