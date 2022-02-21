<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsingPage_Error.aspx.cs" Inherits="ExceptionHandling.ExceptionHandling.UsingPage_Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                    <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="lblError" Font-Bold="true" ForeColor="Red" runat="server"></asp:Label>




    </div>
    </form>
</body>
</html>
