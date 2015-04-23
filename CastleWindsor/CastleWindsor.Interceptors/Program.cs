using Castle.Core;
using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using CastleWindsor.Inter;
using System;

namespace CastleWindsor.Interceptors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Run 2 - configuration fluent");
            using (WindsorContainer container = new WindsorContainer())
            {
                container.Register(
                    Component.For<LogInterceptor>()
                    .ImplementedBy<LogInterceptor>().Named("log"));

                container.Register(
                    Component.For<ISomething>()
                    .ImplementedBy<Something>()
                    .Interceptors(InterceptorReference.ForType<LogInterceptor>()).Anywhere);

                ISomething something = container.Resolve<ISomething>();
                something.DoSomething("apa",114);
                Console.WriteLine("Augment 10 returns " + something.Augment(10));

                // this won't work
                container.Register(Component.For<TestInterceptor>().Named("test"));
                container.Register(Component.For<InnerInterface>().ImplementedBy<InnerClass>().Interceptors(InterceptorReference.ForKey("test")).Anywhere);
                var innerClassInstance = container.Resolve<InnerInterface>();
            }
        }

        class InnerClass : InnerInterface  { }
        interface InnerInterface { }
        class TestInterceptor : IInterceptor
        {
            public void Intercept(IInvocation invocation)
            {
                throw new NotImplementedException();
            }
        }
    }

    //class Test
    //{
    //    public Test(ISomething some)
    //    {
    //        some.DoSomething("input");
    //    }
    //}
}