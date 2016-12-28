using AddPlugIn;
using IPCPlugIn;
using System;

class Program
{
    static void Main(string[] args)
    {
        IPlugIn plugIn = new PlugInProxy();

        plugIn.Init();

        for (int i = 0; i < 3; i++)
        {
            plugIn.PreRun();
            plugIn.Run();
            plugIn.PostRun();
        }

        plugIn.Finish();
        
    }
}