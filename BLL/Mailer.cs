using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Mailer
    {

        public static bool sendMail(string receiver,string subject,string message,string fileAttached = "")
        {
            try
            {
                string sender,password;

                DataAccess da = new DataAccess();
                DataTable db = da.ExecuteQuery(DBQueries.Qmailer);
                sender = db.Rows[0]["email"].ToString();
                password = db.Rows[0]["password"].ToString();

                MailMessage sendmsg = new MailMessage(sender, receiver, subject, message);
                SmtpClient mailer = new SmtpClient("smtp.gmail.com");

                /*
                 https://stackoverflow.com/questions/32260/sending-email-in-net-through-gmail#answer-10784857
                */ 
                 if(fileAttached != "")
                {
                    Attachment attachment;
                    attachment = new Attachment(fileAttached);
                    sendmsg.Attachments.Add(attachment);
                }
                 

                mailer.Port = 587;
                mailer.EnableSsl = true;
                mailer.Credentials = new NetworkCredential(sender, password);
                mailer.Send(sendmsg);
                return true;
            }catch(Exception e){
                throw new Exception(e.Message);
            }
        }
    }
}
