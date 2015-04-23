using Castle.MicroKernel.Registration;
using CastleWindsor.Libs.Contracts;
using CastleWindsor.Libs.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsor.Libs.Installers
{
    public class Installer : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(Component.For<IAuthService>().ImplementedBy<AuthService>());
        }
    }
}
