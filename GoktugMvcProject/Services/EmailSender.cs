using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {
        var smtpClient = new SmtpClient("sandbox.smtp.mailtrap.io")// Mailtrap ya da başka bir fake SMTP servisi kullanabilirsiniz
        {
            Port = 2525,
            Credentials = new NetworkCredential("5dfcde12e6dc0a", "b06191dbd09381"),
            EnableSsl = true,
        };

        return smtpClient.SendMailAsync(
            new MailMessage("arabadananlamiyorum@store.com", email, subject, message)
        );
    }
}
