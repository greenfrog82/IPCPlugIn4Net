using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPlugIn
{
    public interface IPlugIn
    {
        void PreRun(object param = null);

        void Run(object param = null);

        void PostRun(object param = null);
    }
}
