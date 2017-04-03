namespace HelloWorldDI
{
    public class Startup
    {
        public static void Main()
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            var salution = new Salutation(writer);
            salution.Exclaim();
        }
    }
}
