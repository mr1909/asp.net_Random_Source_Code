using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basic_elements.Sample
{
    public partial class TextboxCheckboxRadiobutton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PostGraduateCheckBox.Focus();
            }



            if (!IsPostBack)
            {
                Button4.Attributes.Add("onclick", "return confirm('Do you want to delete the record?');");
            }

    }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sbUserChoices = new StringBuilder();
            if (GraduateCheckBox.Checked)
            {
                sbUserChoices.Append(GraduateCheckBox.Text);
            }
            if (PostGraduateCheckBox.Checked)
            {
                sbUserChoices.Append(", " + PostGraduateCheckBox.Text);
            }
            if (DoctrateCheckBox.Checked)
            {
                sbUserChoices.Append(", " + DoctrateCheckBox.Text);
            }
            Response.Write("Your Selections: " + sbUserChoices.ToString());
        }

        protected void GraduateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Graduate Checkbox Selection changed");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write("Button3_Click!");
        }



        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Write("Button5 Click event handled <br/>");
        }
        protected void Button5_Command(object sender, CommandEventArgs e)
        {
            Response.Write("Button5 Command event handled <br/>");
        }
        protected void CommandButton_Click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Print":
                    OutputLabel.Text = "You clicked Print Button";
                    break;
                case "Delete":
                    OutputLabel.Text = "You clicked Delete Button";
                    break;
                case "Show":
                    if (e.CommandArgument.ToString() == "Top10")
                    {
                        OutputLabel.Text = "You clicked Show Top 10 Employees Button";
                    }
                    else
                    {
                        OutputLabel.Text = "You clicked Show Bottom 10 Employees Button";
                    }
                    break;
                default:
                    OutputLabel.Text = "We don't know which button you clicked";
                    break;
            }
        }
    }
}