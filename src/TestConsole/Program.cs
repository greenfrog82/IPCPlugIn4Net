using AddPlugIn;
using IPCPlugIn;
using System;

class Program
{
    static void Main(string[] args)
    {
        IPlugIn plugIn = new PlugInImpl();

        plugIn.PreRun("Hi python!");
        plugIn.Run();
        plugIn.PostRun();
    }
}