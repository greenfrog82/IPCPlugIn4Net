using IPCPlugIn;
using System;
using System.Diagnostics;
using System.IO;

namespace AddPlugIn
{
    public class PlugInProxy : IPlugIn
    {
        Process process = new Process();

        public PlugInProxy()
        {
        }

        public void PreRun()
        {
            process.StartInfo.FileName = @"C:\Program Files\Python35\python.exe";
            process.StartInfo.Arguments = @"D:\develop\IPCPlugIn4Net\src\PythonStub\PythonStub.py";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            
        }

        public void Run(object param)
        {
            process.StandardInput.WriteLine(param.ToString());
        }

        public void PostRun()
        {
            process.WaitForExit();
            process.Dispose();
        }
    }
}
