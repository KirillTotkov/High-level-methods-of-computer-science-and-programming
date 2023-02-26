using System.Net.Mail;
using System.Net;

namespace Lab1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormPythagoreanSquare());
            Application.Run(new MainForm());
        }

        public static void SendEmailFromMailRu(string toAddress, string mailSubject, string mailBody)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("email@mail.ru");
            message.To.Add(new MailAddress(toAddress));
            message.Subject = mailSubject;
            message.IsBodyHtml = true;
            message.Body = mailBody;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.mail.ru";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;

            string password = "1234";
            smtpClient.Credentials = new NetworkCredential("email@mail.ru", password);

            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Mail send!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }

        }
    }
}