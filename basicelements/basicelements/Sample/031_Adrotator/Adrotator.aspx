<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adrotator.aspx.cs" Inherits="basic_elements.Sample.Adrotator.Adrotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:AdRotator AdvertisementFile="~/Sample/Adrotator/AdsData.xml" ID="AdRotator1" runat="server" Target="_blank" />
    </div>
    </form>
</body>
</html>
