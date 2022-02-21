using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;

namespace ExceptionHandling
{
    public class Logger
    {
        public static void Log(Exception exception)
        {
            Log(exception, EventLogEntryType.Error);
        }

        public static StringBuilder sbExceptionMessage = new StringBuilder();
        public static void Log(Exception exception, EventLogEntryType eventLogEntryType)
        {
            // Create an instance of StringBuilder. This class is in System.Text namespace
            

            do
            {
                sbExceptionMessage.Append("Exception Type" + Environment.NewLine);
                sbExceptionMessage.Append(exception.GetType().Name);
                sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);

                sbExceptionMessage.Append("Message" + Environment.NewLine);
                sbExceptionMessage.Append(exception.Message + Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
                sbExceptionMessage.Append(exception.StackTrace + Environment.NewLine + Environment.NewLine);

                exception = exception.InnerException;
            }
            while (exception != null);


            //for any external use...
            string s = sbExceptionMessage.ToString();



            LogToDB(sbExceptionMessage.ToString());

        }


        private static void LogToDB(string log)
        {
            //// ConfigurationManager class is in System.Configuration namespace
            //string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            //// SqlConnection is in System.Data.SqlClient namespace
            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    SqlCommand cmd = new SqlCommand("spInsertLog", con);
            //    // CommandType is in System.Data namespace
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter parameter = new SqlParameter("@ExceptionMessage", log);
            //    cmd.Parameters.Add(parameter);

            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
        }







        public static void Log2(Exception exception)
        {

            do
            {
                sbExceptionMessage.Append("Exception Type" + Environment.NewLine);
                sbExceptionMessage.Append(exception.GetType().Name);

                sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);

                sbExceptionMessage.Append("Message" + Environment.NewLine);
                sbExceptionMessage.Append(exception.Message + Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
                sbExceptionMessage.Append(exception.StackTrace + Environment.NewLine + Environment.NewLine);

                exception = exception.InnerException;
            }
            while (exception != null);

            string logProvider = ConfigurationManager.AppSettings["LogProvider"];
            if (logProvider.ToLower() == "both")
            {
                LogToDB2(sbExceptionMessage.ToString());
                LogToEventViewer2(sbExceptionMessage.ToString());
            }
            else if (logProvider.ToLower() == "database")
            {
                LogToDB2(sbExceptionMessage.ToString());
            }
            else if (logProvider.ToLower() == "eventviewer")
            {
                LogToEventViewer2(sbExceptionMessage.ToString());
            }
        }

        private static void LogToDB2(string log)
        {
            // ConfigurationManager class is in System.Configuration namespace
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            // SqlConnection is in System.Data.SqlClient namespace
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spInsertLog", con);
                // CommandType is in System.Data namespace
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@ExceptionMessage", log);
                cmd.Parameters.Add(parameter);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private static void LogToEventViewer2(string log)
        {
            if (EventLog.SourceExists("PragimTech.com"))
            {
                // Create an instance of the eventlog
                EventLog eventLog = new EventLog("PragimTech");
                // set the source for the eventlog
                eventLog.Source = "PragimTech.com";
                // Write the exception details to the event log as an error
                eventLog.WriteEntry(log, EventLogEntryType.Error);
            }
        }

























    }



}