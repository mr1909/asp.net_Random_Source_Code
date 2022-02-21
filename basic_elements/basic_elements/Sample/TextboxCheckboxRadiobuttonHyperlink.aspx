<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextboxCheckboxRadiobuttonHyperlink.aspx.cs" Inherits="basic_elements.Sample.TextboxCheckboxRadiobutton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div style="font-family: Arial">
                <fieldset style="width: 350px">
                    <legend><b>Education</b></legend>
                    <asp:CheckBox ID="GraduateCheckBox" Checked="true" Text="Graduate" runat="server"
                        OnCheckedChanged="GraduateCheckBox_CheckedChanged" />

                    <asp:CheckBox ID="PostGraduateCheckBox" Text="Post Graduate" runat="server" />
                    <asp:CheckBox ID="DoctrateCheckBox" Text="Doctrate" runat="server" />
                </fieldset>
                &nbsp;

                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="R" />
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="R" />
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="R" />

                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </div>



            <asp:Button ID="Button2" runat="server" 
OnClientClick="alert('You are about to submit this page')" 
Text="Button" />

            <br />

            <h3>js confirm...</h3>

<%-- If you click cancel, the confirm() function returns false and the webform will not be submitted.
     If you click OK, the confirm() function returns true, and the webform will be posted to the server. --%>

            <asp:Button ID="Button3" runat="server" 
OnClientClick="return confirm('Are you sure you want to delete this record?')" 
Text="Button" OnClick="Button3_Click" />

            <asp:Button ID="Button4" runat="server" Text="Button" />
                        <br />
<asp:Button ID="Button5" runat="server" Text="Button" onclick="Button5_Click" 

    CommandName="Button5" oncommand="Button5_Command" />

            <br />
            <br />

            <h3>oncommand Event...</h3>

            <asp:Button ID="PrintButton" runat="server" Text="Print" oncommand="CommandButton_Click" CommandName="Print"/>

<asp:Button ID="DeletButton" runat="server" Text="Delete" oncommand="CommandButton_Click" CommandName="Delete"/>

<asp:Button ID="Top10Button" runat="server" Text="Show Top 10 Employees" oncommand="CommandButton_Click" 
    CommandName="Show" CommandArgument="Top10"/>

<asp:Button ID="Bottom10Button" runat="server" Text="Show Bottom 10 Employees" oncommand="CommandButton_Click" 
    CommandName="Show" CommandArgument="Bottom10"/>
        
<asp:Label ID="OutputLabel" runat="server"></asp:Label>

            <br />
            <br />
          
            <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>?
            <asp:ImageButton ID="ImageButton1" runat="server" />?
                    
            <br />
            <br />
            <br />
            <br />

            <h1>Properties of a TextBox control</h1>
            <p>
                1. TextMode Propertry - SingleLine, MultiLine and Password.
When you set the TextMode to MultiLine, use Rows property to control the number of lines to display for a MultiLine TextBox.
                <br />
                2. Text - Use this property to set or get the Text from the TextBox.
                <br />
                3. MaxLength - The maximum number of chatacters that a user can enter.
                <br />

                4. ReadOnly - Set this property to true if you don't want the user to change the text in the TextBox.
                <br />
                5. ToolTip - The tooltip is displayed when the mouse is over the control.
                <br />
                6. Columns - Use this property to specify the width of the TextBox in characters
                <br />
                7. Height - Set the height
                <br />
                8. Width - Set the width
                <br />
                9. AutoPostBack - By default, the TextChanged event of a TextBox control is cached in the viewstate, and is executed when the webform is submitted thru a postback by clicking the button control. 
                <br />
                If you want to change this behaviour, and post the webform immediately when the Text is changed, set AutoPostBack to true.
                <br />
                Setting this property to true, will convert the cached event into a postback event.
                <br />



                Events of TextBox:
TextChanged - This event is fired, when the text is changed.
                <br />
                Methods of a TextBox:
Focus - Set input focus onto the control.
            </p>
            <br />
            <br />
            <br />

            <h1>Important Properties of the Radio Button Control</h1>
            <p>
                Checked - This is a boolean property, that is used to check if the button is checked or not.
                <br />
                Text - This is string property used to get or set the text associated with the radio button control
                <br />
                TextAlign - right or left. On which side of the radio button the text should appear
                <br />
                AutoPostBack - Set this property to true, if you want the webform to be posted immediately when the checked status of the radio button changes.
                <br />
                Group Name - By default, the individual radio button selections, are not mutually exclusive.
                <br />
                If you have a group of radio buttons, and if you want the selections among the group to be mutually exclusive, then use the same group name for all the radio button controls.
                <br />
                Events:
CheckedChanged - This event is fired when the checked status of the radio button control is changed.
            </p>
            <br />
            <br />
            <br />

            <h1>Important Properties of the CheckBox Control</h1>
            <p>
                Checked - This is a boolean property, that is used to check if the check box is checked or not.
                <br />
                Text - This is a string property used to get or set the text associated with the check box control
                <br />
                TextAlign - right or left. On which side of the check box the text should appear
                <br />
                AutoPostBack - Set this property to true, if you want the webform to be posted immediately when the checked status of the check box changes.
                <br />
                Methods:
Focus() - Just like TextBox, checkbox also supports, Focus() method. If you want to set the input focus, to a specific checkbox, Call this method for that check box control.
                <br />
                Events:
CheckedChanged - This event is fired when the checked status of the check button control is changed.
            </p>
            <br />
            <br />
            <br />


            <h1>The ASP.NET Hyperlink control is used to create a link to another Web page.</h1>
            <p>

Properties:
Text - The link text that will be shown to the user
                <br />
Navigate URL - The URL of the page to which the user will be sent
                <br />
ImageURL - The URL of the image, that will be displayed for the link. If you specify both the Text and ImageUrl, the image will be displayed instead of the text. If for some reason, the image is not unavailable, the text will be displayed.
                <br />
Target - If target is not specified, the web page to which the hyperlink is linked, will be displayed in the same window. If you set the Target to _blank, the web page will be opened in a new window.
                <br />
Methods:
Focus() - Call this method to Set the input focus when the page loads.
                <br />
Events:
No HyperLink control specific events</p>
            <br />
            <br />
            <br />

            <%--        <h1></h1>
        <p></p>
        <br />
        <br />
        <br />--%>
        </div>
    </form>
</body>
</html>
