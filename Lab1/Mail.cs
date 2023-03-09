using System.Net;
using System.Net.Mail;

namespace Lab1
{
    internal class Mail
    {
        private static string[] GetConfig()
        {
            string filePath = "C:\\Users\\ktotk\\Desktop\\password.txt";
            string fileText = File.ReadAllText(filePath);
            string[] parts = fileText.Split(';');
            string emailFrom = parts[0];
            string password = parts[1];
            return new string[] { emailFrom, password };
        }
        public static void SendEmailFromMailRu(string toAddress, string mailSubject, string mailBody)
        {
            string[] config = GetConfig();
            string emailFrom = config[0];
            string password = config[1];

            MailMessage message = new MailMessage();
            message.From = new MailAddress(emailFrom);
            message.To.Add(new MailAddress(toAddress));
            message.Subject = mailSubject;
            message.IsBodyHtml = true;
            message.Body = mailBody;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.mail.ru";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;

            smtpClient.Credentials = new NetworkCredential("k.totkov@mail.ru", password);

            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Сообщение отправлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
        }
    }
}
