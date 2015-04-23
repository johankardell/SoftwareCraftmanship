using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace CastleWindsor.Inter
{
    public class LogInterceptor : IInterceptor
    {
        #region IInterceptor Members

        public void Intercept(IInvocation invocation)
        {
            var args = "";
            foreach (var arg in invocation.Arguments)
            {
                args += (args.Length > 0 ? ",": "") + arg; 
            }

            Console.WriteLine("on start");
            Console.WriteLine(string.Format("## METHOD: {0} with ARGS:({1})",invocation.Method.Name, args));
            try
            {
                invocation.Proceed();
            }
            catch (Exception)
            {
                Console.WriteLine("it crashed");
                throw;
            }
            finally
            {
                Console.WriteLine("on exit");
            }
            
            
            
        }

        #endregion
    }
}
