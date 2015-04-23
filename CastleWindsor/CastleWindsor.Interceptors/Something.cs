using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsor.Inter
{
    public class Something : ISomething
    {
        #region ISomething Members

        public int Augment(int input)
        {
            return input + 1;
        }

        public void DoSomething(string input, int val)
        {
            Console.WriteLine("I'm doing something: " + input);
        }

        public int Property
        {
            get;
            set;
        }

        #endregion
    }
}
