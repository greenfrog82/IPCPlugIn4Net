using DotNetPlugIn;
using DotNetVO;
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
            Param objParam = param as Param;
            System.Diagnostics.Debug.Assert(null != objParam);

            Console.WriteLine(objParam.PreRun);
        }

        public void Run(object param = null)
        {
            Param objParam = param as Param;
            System.Diagnostics.Debug.Assert(null != objParam);

            Console.WriteLine(objParam.Run);
        }

        public void PostRun(object param = null)
        {
            Param objParam = param as Param;
            System.Diagnostics.Debug.Assert(null != objParam);

            Console.WriteLine(objParam.PostRun);
        }
    }
}
