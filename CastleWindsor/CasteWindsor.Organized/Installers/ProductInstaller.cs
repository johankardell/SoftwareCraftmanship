using CasteWindsor.Organized.Features.Products.Contracts;
using CasteWindsor.Organized.Features.Products.Impl;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasteWindsor.Organized.Installers
{
    public class ProductInstaller: IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(Component.For<ICategory>().ImplementedBy<Category>());
            container.Register(Component.For<IProduct>().ImplementedBy<Product>());
        }
    }
}
