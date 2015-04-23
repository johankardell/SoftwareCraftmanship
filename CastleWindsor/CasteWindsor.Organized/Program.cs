using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using CasteWindsor.Organized.Installers;
using CasteWindsor.Organized.Features.Login.Contracts;
using Castle.Windsor.Installer;
using CastleWindsor.Libs.Contracts;
using CastleWindsor.Organized.Consumer;

namespace CasteWindsor.Organized
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // SAME ASSEMBLY

            var container = new WindsorContainer();

            container.Install(new ProductInstaller());
            container.Install(new LoginInstaller());
            var service = container.Resolve<ILoginService>();

            // DIFFERENT ASSEMBLIES
            container.Install(FromAssembly.Named("CastleWindsor.Libs"));

            container.Register(Component.For<Consumer>());
            var consumer = container.Resolve<Consumer>();

            var authService = container.Resolve<IAuthService>();
            authService.Authenticate("user", "pass");

            

        }
    }
}
