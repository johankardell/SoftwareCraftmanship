using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace CastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(Component.For<PaymentService>());


            var myBossMasterCard = new MasterCard("My boss's name", "123456789-123");

            // INSTANCE, resolve against this instance, all the time
            container.Register(Component.For<ICard>().Instance(myBossMasterCard));

            // NORMAL register
            //container.Register(Component.For<ICard>().ImplementedBy<VisaCard>());

            // NAMED register
            container.Register(Component.For<ICard>().ImplementedBy<VisaCard>().Named("myCard"));
            container.Register(Component.For<ICard>().ImplementedBy<AmericanExpress>().Named("wifesCard"));

            var creditCard = container.Resolve<ICard>();

            var myCard = container.Resolve<ICard>("myCard");

            // LIFECYCLE:  SINGLETON, TRANSIENT
            var wifesCard = container.Resolve<ICard>("wifesCard");
            var mistressCard = container.Resolve<ICard>("wifesCard");

            var allCards = container.ResolveAll<ICard>();

            var paymentService = container.Resolve<PaymentService>();

            //LIFECYCLE, default singleton, unity is default transient aka new object
            // container.Register(Component.For<ICard>().LifeStyle.Transient.ImplementedBy<AmericanExpress>().Named("wifesCard"));
        }
    }

    interface ICard 
    { 
        
    }

    class AmericanExpress : ICard 
    {
        private int _value;

        public AmericanExpress()
        {
            _value = new Random().Next(100);
        }
    }

    class VisaCard : ICard
    { 
    
    }

    class MasterCard : ICard
    {
        private string _name;
        private string _accountNo;

        public MasterCard(string name, string accountNo)
        {
            this._name = name;
            this._accountNo = accountNo;
        }
    }


    class PaymentService 
    {
        public PaymentService(ICard card)
        {

        }
    }
}
