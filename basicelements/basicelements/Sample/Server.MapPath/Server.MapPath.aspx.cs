using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basic_elements.Sample
{
    public partial class Server_MapPath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(". returns " + Server.MapPath(".") + "<br/>");

            Response.Write(".. returns " + Server.MapPath("..") + "<br/>");
            Response.Write("~ returns " + Server.MapPath("~") + "<br/>");

            DataSet DS = new DataSet();
            DS.ReadXml(Server.MapPath("../Assets/XML/dropdownlist.xml"));

            DropDownList1.DataTextField = "CountryName";
            DropDownList1.DataValueField = "CountryId";
            DropDownList1.DataSource = DS;
            DropDownList1.DataBind();
        }
    }
}