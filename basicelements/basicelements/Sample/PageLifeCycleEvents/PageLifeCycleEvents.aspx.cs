using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basic_elements.Sample
{
    public partial class PageLifeCycleEvents : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit" + "<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init" + "<br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page_InitComplete" + "<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_PreLoad" + "<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load" + "<br/>");

            //if AutoPostBack is true then on TextChange event will be triggered!
            TextBox1.AutoPostBack = false;


            //adding EventHandler to button in Page_Load
            //Button1.Click += new EventHandler(Button1_Click);
            //Button1.Command += new CommandEventHandler(Button1_Command);

        }


        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page_LoadComplete" + "<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender" + "<br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page_PreRenderComplete" + "<br/>");
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed Event" + "<br/>");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button Click" + "<br/>");
        }


    }
}