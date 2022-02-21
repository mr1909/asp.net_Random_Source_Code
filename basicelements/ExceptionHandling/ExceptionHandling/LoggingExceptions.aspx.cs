using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionHandling.ExceptionHandling
{
    public partial class LoggingExceptions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int FirstNumber = Convert.ToInt32(txtFirstNumber.Text);
                int SecondNumber = Convert.ToInt32(txtSecondNumber.Text);

                lblMessage.ForeColor = System.Drawing.Color.Navy;
                int Result = FirstNumber / SecondNumber;
                lblMessage.Text = Result.ToString();
            }
            catch (FormatException formatException)
            {
                Logger.Log(formatException, EventLogEntryType.Information);
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Only numbers are allowed";
            }
            catch (OverflowException overflowException)
            {
                Logger.Log(overflowException, EventLogEntryType.Information);
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Numbers must be between " + Int32.MinValue.ToString() + " and " + Int32.MaxValue.ToString();
            }
            catch (DivideByZeroException divideByZeroException)
            {
                Logger.Log(divideByZeroException, EventLogEntryType.Information);
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Denominator cannot be ZERO";
            }
            catch (Exception exception)
            {
                Logger.Log(exception);
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "An unknown problem has occured. Please try later";
            }
        }


    }
}