using CasteWindsor.Organized.Features.Login.Contracts;
using CasteWindsor.Organized.Features.Login.Impl;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasteWindsor.Organized.Installers
{
    public class LoginInstaller : IWindsorInstaller
    {
        public void Install( 
            Castle.Windsor.IWindsorContainer container, 
            Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(Component.For<IUser>().ImplementedBy<WebUser>());
            container.Register(Component.For<ILoginService>().ImplementedBy<LoginService>());
        }
    }
}
