using CastleWindsor.Libs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsor.Libs.Impl
{
    public class AuthService : IAuthService
    {
        public bool Authenticate(string username, string password)
        {
            Console.WriteLine("authenticating");
            return true;
        }
    }
}
