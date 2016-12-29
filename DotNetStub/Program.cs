using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStub
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            while("q" != cmd)
            {
                switch(cmd)
                {
                    case "pre":
                        Console.WriteLine("PreRun");
                        break;
                    case "run":
                        Console.WriteLine("Run");
                        break;
                    case "post":
                        Console.WriteLine("PostRun");
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false, cmd);
                        break;
                }
                cmd = Console.ReadLine();
            }

            Console.WriteLine("DotNetStub has been finished by PlugInProxy.");
        }
    }
}
