using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poeteq.FundingAvenue.Models
{
    public interface IMailConfiguration
    {
        string SmtpServer { get;}
        int SmtpPort { get; }
        string EmailTo { get; }
        string AuthenticationRemoval { get;  }
        string AuthenticatedEmailAddress { get;  }
        string AuthenticatedEmailPassword { get; }
        string TextStyle { get;}

    }
    public class MailConfiguration : IMailConfiguration
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string EmailTo { get; set; }
        public string AuthenticationRemoval { get; set; }
        public string AuthenticatedEmailAddress { get; set; }
        public string AuthenticatedEmailPassword { get; set; }
        public string TextStyle { get; set; }

    }
}
