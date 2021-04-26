using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace _10_Sending_Email
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                https://ethereal.email/

                Host	    smtp.ethereal.email
                Port	    587
                Security	STARTTLS
                Name	    Alvah Baumbach
                Username	alvah.baumbach43@ethereal.email
                Password	hjhZn93YTDb1Kjd1VA
             */

            // create email message
            var email = new MimeMessage();

            email.From.Add(MailboxAddress.Parse("alvah.baumbach43@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("pravoslav.milenkov@gmail.com"));

            email.Subject = "Test Email Subject";
            email.Body = new TextPart(TextFormat.Plain) { Text = "Example Plain Text Message Body" };

            // send email
            using var smtp = new SmtpClient();

            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTlsWhenAvailable);
            smtp.Authenticate("alvah.baumbach43@ethereal.email", "hjhZn93YTDb1Kjd1VA");

            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}