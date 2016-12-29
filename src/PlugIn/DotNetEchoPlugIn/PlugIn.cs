using DotNetPlugIn;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetEchoPlugIn
{
    [Export(typeof(IPlugIn))]
    public class PlugIn : IPlugIn
    {
        public void PreRun(object param = null)
        {
            Console.WriteLine(param);
        }

        public void Run(object param = null)
        {
            Console.WriteLine(param);
        }

        public void PostRun(object param = null)
        {
            Console.WriteLine(param);
        }
    }
}
