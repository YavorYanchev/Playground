using NinjectInjectsDependenciesForUs.Logging;
using System;

namespace NinjectInjectsDependenciesForUs.Mailing
{
    public class MockMailSender : IMailSender
    {
        private readonly ILogging logging;

        public MockMailSender(ILogging logging)
        {
            this.logging = logging;
        }

        public void Send(string toAddress, string subject)
        {
            logging.Debug("Sending mail");
            Console.WriteLine("Mocking mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}
