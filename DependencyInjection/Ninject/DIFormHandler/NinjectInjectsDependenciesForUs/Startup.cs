using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NinjectInjectsDependenciesForUs
{
    public class Startup
    {
        public static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var mailSender = kernel.Get<IMailSender>();

            var formHandler = new FormHandler(mailSender);
            formHandler.Handle("test@test.com");

            Console.ReadLine();
        }
    }
}
