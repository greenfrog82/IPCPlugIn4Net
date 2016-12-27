using IPCPlugIn;
using System;

namespace AddPlugIn
{
    public class PlugInImpl : IPlugIn
    {
        public PlugInImpl()
        {
            
        }

        public void PreRun(object param)
        {
            System.Diagnostics.Process.Start("cmd");
        }

        public void PostRun()
        {
            //throw new NotImplementedException();
        }

        public void Run()
        {
            //throw new NotImplementedException();
        }
    }
}
