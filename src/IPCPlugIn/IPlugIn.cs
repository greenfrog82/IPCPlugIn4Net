using System;
using System.Collections.Generic;
using System.Text;

namespace IPCPlugIn
{
    public interface IPlugIn
    {
        void PreRun();

        void Run(object param);

        void PostRun();
    }
}
