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
        //public void SendEventMail(string toEmail, string eventSubject, string eventBody)
        //{
        //    // Gönderici bilgileri
        //    string fromAddress = "tasktrackingproje@gmail.com";
        //    string password = "madakoor132";

        //    // Alıcı bilgileri
        //    string toAddress = toEmail;

        //    // Mail konfigürasyonu
        //    MailMessage message = new MailMessage(fromAddress, toAddress);
        //    message.Subject = eventSubject;
        //    message.Body = eventBody;

        //    // SMTP sunucu konfigürasyonu
        //    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
        //    smtpClient.Port = 587;
        //    smtpClient.Credentials = new NetworkCredential(fromAddress, password);
        //    smtpClient.EnableSsl = true;

        //    try
        //    {
        //        // Mail gönderme işlemi
        //        smtpClient.Send(message);
        //        MessageBox.Show("Mail Gönderildi");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Hata oluştu : " + ex.Message);
        //    }


        //}
        public void SendEventMail()
        {
            string fromAddress = "tasktrackingproje@gmail.com";
            string password = "cfvh jflf visu gurh";

            string toAddress = "melihakyildiz0206@gmail.com";

            MailMessage message = new MailMessage(fromAddress, toAddress);
            message.Subject = "Konu: Merhaba, Mail Başlığı!";
            message.Body = "Merhaba, Bu bir test mailidir.";

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
