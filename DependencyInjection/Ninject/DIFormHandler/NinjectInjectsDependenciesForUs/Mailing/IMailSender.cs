namespace NinjectInjectsDependenciesForUs.Mailing
{
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
}
