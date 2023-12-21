using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaskTracking.PresentationLayer.Services
{
    public class MailSendServices
    {
        public void SendEventMail(string eventBody, string eventToMail)
        {
            string fromAddress = "tasktrackingproje@gmail.com";
            string password = "cfvh jflf visu gurh";

            string toAddress = eventToMail;

            MailMessage message = new MailMessage(fromAddress, toAddress);
            message.Subject = "Yeni Etkinlik";
            message.Body = eventBody;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential(fromAddress, password);
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Mail Gönderildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu : " + ex.Message);
            }
        }
    }
}
