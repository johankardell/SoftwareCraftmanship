using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsor.Inter
{
    public interface ISomething
    {
        Int32 Augment(Int32 input);
        void DoSomething(String input, int val);
        Int32 Property { get; set; }
    }
}
