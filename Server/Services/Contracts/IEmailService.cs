using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnWithQB.Server.Services.Contracts
{
    public interface IEmailService
    {
        void SendAsync(SendGrid.SendGridMessage message);
    }
}