using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MailServices
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            SendEmail_method_1("111111111111");

            //reading data from Web.config
            SendEmail_method_2("222222222222");

        }




        public static void SendEmail_method_1(string emailbody)
        {
            // Specify the from and to email address
            MailMessage mailMessage = new MailMessage("phoenix.k.1909@gmail.com", "phoenix.k.1909@gmail.com");
            // Specify the email body
            mailMessage.Body = emailbody;
            // Specify the email Subject
            mailMessage.Subject = "Subject";

            // Specify the SMTP server name and post number
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            // Specify your gmail address and password
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "phoenix.k.1909@gmail.com",
                Password = ""
            };
            // Gmail works on SSL, so set this property to true
            smtpClient.EnableSsl = true;
            // Finall send the email message using Send() method
            smtpClient.Send(mailMessage);
        }


        public static void SendEmail_method_2(string emailbody)
        {
            // Specify the from and to email address
            MailMessage mailMessage = new MailMessage
                ("from_email@gmail.com", "mr1909kk@gmail.com");
            // Specify the email body
            mailMessage.Body = emailbody;
            // Specify the email Subject
            mailMessage.Subject = "Exception";

            // No need to specify the SMTP settings as these 
            // are already specified in web.config
            SmtpClient smtpClient = new SmtpClient();
            // Finall send the email message using Send() method
            smtpClient.Send(mailMessage);
        }






        //for method 2
        //There is security setting which you should turn off in your gmail account(for the account to which you send the mail).
        //Check this "https://www.google.com/settings/security/lesssecureapps"




    }
}