using System;
using System.Collections.Generic;
using System.Text;

namespace IPCPlugIn
{
    public interface IPlugIn
    {
        void PreRun(object param);

        void Run();

        void PostRun();
    }
}
