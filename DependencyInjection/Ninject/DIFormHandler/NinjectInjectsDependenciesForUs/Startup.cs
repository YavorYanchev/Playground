using Ninject;
using NinjectInjectsDependenciesForUs.Mailing;
using System;
using System.Reflection;

namespace NinjectInjectsDependenciesForUs
{
    public class Startup
    {
        public static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var mailSender = kernel.Get<IMailSender>();

            //var formHandler = new FormHandler(mailSender);
            //formHandler.Handle("test@test.com");

            var secondFormHandler = kernel.Get<IFormHandler>();
            secondFormHandler.Handle("test2@test2.com");

            Console.ReadLine();
        }
    }
}
