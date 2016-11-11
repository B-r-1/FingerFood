using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Base.Utils {
	public class Mailing {

    //    public static void SendGenericMail(string subject, string message, String to) {
    //        System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
			
    //        string mailSender = ConfigurationManager.AppSettings["MailReceiver"].ToString(); 

    //        string mailReceiver;

    //        if (String.IsNullOrEmpty(to)) {
    //            mailReceiver = ConfigurationManager.AppSettings["MailReceiver"].ToString();
    //        }
    //        else {
    //            mailReceiver = to;
    //        }

    //        string host = ConfigurationManager.AppSettings["Host"].ToString();
    //        string passwordMailSender = ConfigurationManager.AppSettings["PasswordMailSender"].ToString();

    //        if (mailSender != null && mailReceiver != null && host != null) {
    //            mailMessage.From = new System.Net.Mail.MailAddress(mailSender);
    //            mailMessage.To.Add(mailReceiver);
    //            mailMessage.Subject = subject;
    //            mailMessage.Body = message;
    //            mailMessage.IsBodyHtml = true;
    //            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
    //            smtp.EnableSsl = true;
    //            smtp.Host = host;
    //            smtp.Credentials = new System.Net.NetworkCredential(mailSender, passwordMailSender);

    //            try {
    //                smtp.Send(mailMessage);
    //            }
    //            catch (Exception ex) {
    //                System.Diagnostics.Trace.WriteLine(ex.Message);
    //            }
    //        }
    //    }
    }
}
