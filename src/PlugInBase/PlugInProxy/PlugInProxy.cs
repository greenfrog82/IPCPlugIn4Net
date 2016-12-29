using IPCPlugIn;
using System;
using System.Diagnostics;
using System.IO;

namespace PlugInProxy
{
    public class PlugInProxy : IPlugIn
    {
        Process process = new Process();

        public PlugInProxy(string executorFilePath, string arguments)
        {
            //process.StartInfo.FileName = @"C:\Program Files\Python35\python.exe";
            //process.StartInfo.Arguments = @"D:\develop\IPCPlugIn4Net\src\PythonStub\PythonStub.py";
            process.StartInfo.FileName = executorFilePath;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
        }

        public void PreRun(object param = null)
        {
            process.StandardInput.WriteLine("pre");
            Console.WriteLine(process.StandardOutput.ReadLine());
        }

        public void Run(object param = null)
        {
            process.StandardInput.WriteLine("run");
            Console.WriteLine(process.StandardOutput.ReadLine());
        }

        public void PostRun(object param = null)
        {
            process.StandardInput.WriteLine("post");
            Console.WriteLine(process.StandardOutput.ReadLine());
        }

        public void Finish(object param = null)
        {
            process.StandardInput.WriteLine("q");
            Console.WriteLine(process.StandardOutput.ReadLine());
            process.WaitForExit();
            process.Dispose();
        }
    }
}
