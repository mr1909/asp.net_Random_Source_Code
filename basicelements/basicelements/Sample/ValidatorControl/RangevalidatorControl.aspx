<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RangevalidatorControl.aspx.cs" Inherits="basic_elements.Sample.ValidatorControl.RangevalidatorControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        <table>
    <tr>
        <td>
            <b>Age</b>
        </td>
        <td>
            :<asp:TextBox ID="txtAge" runat="server" Width="150px">
                </asp:TextBox>
            <asp:RangeValidator ID="RangeValidatorAge" runat="server" 
                ErrorMessage="Age must be between 1 & 100"
                MinimumValue="1" MaximumValue="100"
                ControlToValidate="txtAge" Type="Integer" 
                ForeColor="Red" Display="Dynamic">
            </asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge" 
            runat="server" ErrorMessage="Age is required" 
            ControlToValidate="txtAge" ForeColor="Red"
            Display="Dynamic" >
            </asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <b>Date Available</b>
        </td>
        <td>
            :<asp:TextBox ID="txtDateAvailable" runat="server" Width="150px">
            </asp:TextBox>
            <asp:RangeValidator ID="RangeValidatorDateAvailable" runat="server" 
                ErrorMessage="Date must be between 2000/01/20 & 2020/12/27"

                MinimumValue="2000/01/20" MaximumValue="2020/12/27"
                ControlToValidate="txtDateAvailable" Type="Date" 
                ForeColor="Red">
            </asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="btnSave" runat="server" Text="Save" Width="100px" 
                onclick="btnSave_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="lblStatus" runat="server" Font-Bold="true">
            </asp:Label>
        </td>
    </tr>
</table>











    </div>
    </form>
</body>
</html>
