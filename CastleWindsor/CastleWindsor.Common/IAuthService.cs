﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsor.Libs.Contracts
{
    public interface IAuthService
    {
        bool Authenticate(string username, string password);
    }
}
