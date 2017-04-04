using Ninject.Modules;
using NinjectInjectsDependenciesForUs.Logging;
using NinjectInjectsDependenciesForUs.Mailing;

namespace NinjectInjectsDependenciesForUs
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogging>().To<MockLogging>();
            Bind<IMailSender>().To<MockMailSender>();
            Bind<IFormHandler>().To<FormHandler>();
        }
    }
}
