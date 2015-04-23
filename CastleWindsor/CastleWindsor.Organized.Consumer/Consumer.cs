using CastleWindsor.Libs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsor.Organized.Consumer
{
    public class Consumer
    {
        public Consumer(IAuthService service)
        {
            service.Authenticate("test", "test");
        }
    }
}
