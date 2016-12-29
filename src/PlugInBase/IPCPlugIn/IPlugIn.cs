using System;
using System.Collections.Generic;
using System.Text;

namespace IPCPlugIn
{
    public interface IPlugIn
    {
        void PreRun(object param = null);

        void Run(object param = null);

        void PostRun(object param = null);

        void Finish(object param = null);
    }
}
