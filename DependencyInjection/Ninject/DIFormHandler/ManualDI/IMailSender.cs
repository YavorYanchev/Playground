namespace ManualDI
{
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
}
