<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Server.MapPath.aspx.cs" Inherits="basic_elements.Sample.Server_MapPath" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <br />
        <p>
            From the output, it should be clear that
            <br />
Server.MapPath(".") returns the current physical directory of the page that you are running
            <br />
Server.MapPath("..") returns the parent pysical directory of the page that you are running
            <br />
Server.MapPath("~") returns the physical path of the root directory of the application
        </p>
    <br />
        <br />
        <br />

        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

        <p>
            C:\SampleWeb\SampleWeb is the root directory for the sample asp.net web application that we used in the Demo.
                    <br /> To get to this root directory we are passing ../../ to the Server.MapPath() method as shown below.
                    <br />
DS.ReadXml(Server.MapPath("../../Data/Countries/Countries.xml"));
                    <br />

The number of double dots, that you use, depends on how deep you are in the folder hierarchy. 
                    <br />To avoid confusion, if any time you want to navigate to the root directory of the application, it is better to use ~(tilde) character as shown below.
                    <br />
DS.ReadXml(Server.MapPath("~/Data/Countries/Countries.xml"));
                    <br />

Tilde(~) symbol resolves to the root application directory, no matter how deep you are in the folder hierarchy.
                    <br /> This is the advantage of using ~(tilde), over ..(2 Dots). The following code would work from any folder in our application.
                    <br />
DS.ReadXml(Server.MapPath("~/Data/Countries/Countries.xml"));
                    <br />
Where as, the following code will only work from folders, that are 2 levels deeper relative to the root directory of the application.
        <br />
DS.ReadXml(Server.MapPath("../../Data/Countries/Countries.xml"));

        </p>


    </div>
    </form>
</body>
</html>
