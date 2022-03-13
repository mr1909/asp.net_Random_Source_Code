using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basic_elements.Sample.Calendar
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                Calendar2.Visible = false;
            }
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }


        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar2.Visible)
            {
                Calendar2.Visible = false;
            }
            else
            {
                Calendar2.Visible = true;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;

            Response.Write("ToString() - " + DateTime.Now.ToString() + "<br/>");
            Response.Write("ToLongDateString() - " + DateTime.Now.ToLongDateString() + "<br/>");

            Response.Write("ToShortDateString() - " + DateTime.Now.ToShortDateString() + "<br/>");
            Response.Write("ToLongTimeString() - " + DateTime.Now.ToLongTimeString() + "<br/>");
            Response.Write("ToShortTimeString() - " + DateTime.Now.ToShortTimeString() + "<br/><br/>");

            Response.Write("d - " + DateTime.Now.ToString("d") + "<br/>");
            Response.Write("D - " + DateTime.Now.ToString("D") + "<br/>");

            Response.Write("dd/MM/yyyy - " + DateTime.Now.ToString("dd/MM/yyyy") + "<br/>");
            Response.Write("dd/MMMM/yyyy - " + DateTime.Now.ToString("dd/MMMM/yyyy") + "<br/>");
            Response.Write("dd/MMMM/yy - " + DateTime.Now.ToString("dd/MMMM/yy") + "<br/>");
            Response.Write("MM/dd/yy - " + DateTime.Now.ToString("MM/dd/yy") + "<br/><br/>");

        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsWeekend || e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.LightGray;
            }
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar2.SelectedDate.ToShortDateString();

            foreach (DateTime selectedDate in Calendar2.SelectedDates)
            {
                Response.Write(selectedDate.ToShortDateString() + "<br/>");
            }


        }

        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {
            if (!e.Day.IsOtherMonth && e.Day.Date.Day % 2 == 0)
            {
                e.Cell.Text = "x";
                e.Cell.Font.Bold = true;
                e.Cell.ForeColor = System.Drawing.Color.White;
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ToolTip = "Booked";
            }
            else
            {
                e.Cell.ToolTip = "Available";
            }
        }


        protected void Calendar2_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            Response.Write("Month changed from ");
            Response.Write(GetMonthName(e.PreviousDate.Month));
            Response.Write(" to ");
            Response.Write(GetMonthName(e.NewDate.Month));
        }
        private string GetMonthName(int MonthNumber)
        {
            switch (MonthNumber)
            {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                case 4:
                    return "Apr";
                case 5:
                    return "May";
                case 6:
                    return "Jun";
                case 7:
                    return "Jul";
                case 8:
                    return "Aug";
                case 9:
                    return "Sep";
                case 10:
                    return "Oct";
                case 11:
                    return "Nov";
                case 12:
                    return "Dec";
                default:
                    return "Invalid Month";
            }
        }

    }
}