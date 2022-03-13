using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basic_elements.Sample._034_HiddenField
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Load()
        {

            HiddenField1.Value = "Test for HiddenField";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                TextBox1.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Load();
            TextBox1.Text = HiddenField1.Value;
        }

    }
}