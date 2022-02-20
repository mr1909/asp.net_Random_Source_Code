<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextboxCheckboxRadiobutton.aspx.cs" Inherits="basic_elements.Sample.TextboxCheckboxRadiobutton" %>

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

                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="R"/>
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="R" />
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="R"/>

                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </div>





            <br />
            <br />
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

            <%--        <h1></h1>
        <p></p>
        <br />
        <br />
        <br />--%>
        </div>
    </form>
</body>
</html>
