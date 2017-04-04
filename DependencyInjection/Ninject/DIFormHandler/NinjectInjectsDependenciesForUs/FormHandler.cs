using NinjectInjectsDependenciesForUs.Mailing;

namespace NinjectInjectsDependenciesForUs
{
    public class FormHandler:IFormHandler
    {
        private readonly IMailSender mailSender;

        public FormHandler(IMailSender mailSender)
        {
            this.mailSender = mailSender;
        }

        public void Handle(string toAddress)
        {
            mailSender.Send(toAddress, "This is Ninject example");
        }
    }
}
