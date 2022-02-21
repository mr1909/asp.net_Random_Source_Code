<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dropdownlist.aspx.cs" Inherits="basic_elements.Sample.DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <h3>load data in design mode...</h3>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">item1</asp:ListItem>
                <asp:ListItem Value="2" Selected="True">item2</asp:ListItem>
            </asp:DropDownList>



            <br />
            <br />

                        <h3>load data from sql db.</h3>
            <asp:DropDownList ID="DropDownList2" DataTextField="CityName"
                DataValueField="CityId" runat="server">
            </asp:DropDownList>
            
            <br />
            <br />


                                    <h3>load data from XML File.</h3>
            <asp:DropDownList ID="DropDownList3" DataTextField="CityName"
                DataValueField="CityId" runat="server">
            </asp:DropDownList>



                        <br />
            <br />            <br />
            <br />



            <asp:DropDownList ID="ddlContinents" Width="200px" DataTextField="ContinentName" 
    DataValueField="ContinentId" runat="server" AutoPostBack="True" 
    onselectedindexchanged="ddlContinents_SelectedIndexChanged">
</asp:DropDownList>
<br /><br />
<asp:DropDownList ID="ddlCountries" DataValueField="CountryId" 
    DataTextField="CountryName" Width="200px" runat="server" AutoPostBack="True" 
    onselectedindexchanged="ddlCountries_SelectedIndexChanged">
</asp:DropDownList>
<br /><br />
<asp:DropDownList ID="ddlCities" Width="200px" DataTextField="CityName" 
    DataValueField="CityId" runat="server">
</asp:DropDownList> 





            <%--        <h1></h1>
        <p></p>
        <br />
        <br />
        <br />--%>
        </div>
    </form>
</body>
</html>
