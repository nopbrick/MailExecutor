using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Executor
{
    internal class Invoker
    {
        public static Assembly Invoke(byte[] bin)
        {
            var asm = Assembly.Load(bin);
            return asm;
        }

        public static void Run(Assembly assembly, string[] param)
        {
            assembly.EntryPoint.Invoke(null, new object[] { param });
        }
    }
}
