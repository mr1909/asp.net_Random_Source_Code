<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fileupload.aspx.cs" Inherits="basic_elements.Sample.Fileupload.Fileupload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>


        <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;
<asp:Button ID="btnUpload" runat="server" Text="Upload File from system Client to Server" 
    onclick="btnUpload_Click" Width="272px" />
<br />
<asp:Label ID="lblMessage" Font-Bold="true" runat="server">
</asp:Label>




    
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextboxURL" runat="server" Width="372px"></asp:TextBox>
        <asp:Button ID="btnUpload_url" runat="server" Text="Upload File from URL to Server" OnClick="btnUpload_url_Click" />




    
    </div>
    </form>
</body>
</html>
