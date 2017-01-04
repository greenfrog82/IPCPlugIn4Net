using IPCPlugIn;
using System;

class Program
{
    static void Main(string[] args)
    {
        string json = System.IO.File.ReadAllText(@".\sample.json");
        
        //IPlugIn plugIn = new PlugInProxy.PlugInProxy(
        //        @"C:\Program Files\Python35\python.exe",
        //        @"D:\develop\IPCPlugIn4Net\src\PlugIn\PythonEchoPlugIn\PythonStub.py");

        IPlugIn plugIn = new PlugInProxy.PlugInProxy(
                @"D:\develop\IPCPlugIn4Net\src\PlugInBase\DotNet\DotNetStub\bin\Debug\DotNetStub.exe",
                null);

        //for (int i = 0; i < 3; i++)
        //{
            plugIn.PreRun(json);
            plugIn.Run(json);
            plugIn.PostRun(json);
        //}

        plugIn.Finish();
        
    }
}