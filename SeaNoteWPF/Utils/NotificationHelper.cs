using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace SeaNoteWPF.Utils
{
    public static class NotificationHelper
    {
        private static string senderEmail = ConfigHelper.EmailUser;
        private static string senderPassword = ConfigHelper.EmailPass; // Ambil dari config encrypted

        public static void SendUrgentEmail(string toEmail, string subject, string body)
        {
            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail, senderPassword)
                };
                smtp.SendMailAsync(new MailMessage(senderEmail, toEmail, "[URGENT] " + subject, body));

                string logMsg = $"[EMAIL SENT] {subject}: {body}";
                MessageService.SendSystemAlert("owner", logMsg); // Lapor ke Owner
            }
            catch (Exception ex) { ToastHelper.ShowError("Email Error: " + ex.Message); }
        }

        public static void SendWhatsApp(string phone, string message)
        {
            try
            {
                string url = $"https://wa.me/{phone}?text={Uri.EscapeDataString(message)}";
                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });

                string logMsg = $"[WA SENT] {message}";
                MessageService.SendSystemAlert("owner", logMsg); 
            }
            catch { ToastHelper.ShowError("WA Error"); }
        }
    }
}