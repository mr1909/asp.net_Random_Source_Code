<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="basic_elements.Sample._034_HiddenField.HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <asp:HiddenField ID="HiddenField1" runat="server" />

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>


<asp:Button ID="Button1" runat="server" Text="Clear" 
    onclick="Button1_Click" />&nbsp;
<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
    Text="Load" />

    </div>
    </form>
</body>
</html>
