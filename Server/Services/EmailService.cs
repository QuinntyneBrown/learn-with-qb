using System.Net;
using LearnWithQB.Server.Services.Contracts;
using LearnWithQB.Server.Config;

namespace LearnWithQB.Server.Services
{
    public class EmailService: IEmailService
    {
        public EmailService()
        {

        }

        public void SendAsync(SendGrid.SendGridMessage message)
        {
            var config = SmtpConfiguration.Config;            
            var transportWeb = new SendGrid.Web(new NetworkCredential(config.Username, config.Password));
            transportWeb.DeliverAsync(message);
        }        
    }
}