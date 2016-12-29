using AddPlugIn;
using IPCPlugIn;
using System;

class Program
{
    static void Main(string[] args)
    {
        //IPlugIn plugIn = new PlugInProxy(
        //        @"C:\Program Files\Python35\python.exe", 
        //        @"D:\develop\IPCPlugIn4Net\src\PythonStub\PythonStub.py");

        IPlugIn plugIn = new PlugInProxy(
                @"D:\develop\IPCPlugIn4Net\DotNetStub\bin\Debug\DotNetStub.exe",
                null);

        for (int i = 0; i < 3; i++)
        {
            plugIn.PreRun();
            plugIn.Run();
            plugIn.PostRun();
        }

        plugIn.Finish();
        
    }
}