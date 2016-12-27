using AddPlugIn;
using IPCPlugIn;
using System;

class Program
{
    static void Main(string[] args)
    {
        IPlugIn plugIn = new PlugInProxy();

        plugIn.PreRun();
        plugIn.Run("Hi python!");
        plugIn.PostRun();
    }
}