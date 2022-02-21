using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionHandling.ExceptionHandling
{
    public partial class UsingPage_Error : System.Web.UI.Page
    {


        //protected void Page_Load(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        ds.ReadXml(Server.MapPath("~/1Countries.xml"));
        //        GridView1.DataSource = ds;
        //        GridView1.DataBind();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    finally
        //    {
        //    }




        //}

        //protected void Page_Error(object sender, EventArgs e)
        //{
        //    // Get the exception details and log it in the database or event viewer
        //    Exception ex = Server.GetLastError();
        //    // Clear the exception
        //    Server.ClearError();
        //    // Redirect user to Error page
        //    Response.Redirect("~/Errors.aspx");
        //}


        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();


            ds.ReadXml(Server.MapPath("~/1Countries.xml"));

            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void Page_Error(object sender, EventArgs e)
        {

            Exception ex = Server.GetLastError();
            Server.ClearError();
            Response.Redirect("~/Errors.aspx");

        }


    }
}