using IPCPlugIn;
using System;

namespace AddPlugIn
{
    public class PlugInImpl : IPlugIn
    {
        
        public PlugInImpl()
        {
            // TODO .NET Core에서 .NET Framework에서 사용하는 Process.Start라는 메소드를 사용할 수 없는가?
            //System.Diagnostics.
            Process.Start
        }

        public void PreRun(object param)
        {
            throw new NotImplementedException();
        }

        public void PostRun()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
