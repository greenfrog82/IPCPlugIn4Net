using DotNetPlugIn;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStub
{
    class Program
    {
        private CompositionContainer _container;

        [Import(typeof(IPlugIn))]
        public IPlugIn plugIn;

        private Program()
        {
            //An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();
            //Adds all the parts found in the same assembly as the Program class
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog(@"D:\develop\IPCPlugIn4Net\src\PlugIn\DotNetEchoPlugIn\bin\Debug"));

            //Create the CompositionContainer with the parts in the catalog
            _container = new CompositionContainer(catalog);

            //Fill the imports of this object
            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                System.Diagnostics.Debug.Assert(false, compositionException.ToString());
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program(); //Composition is performed in the constructor

            string cmd = Console.ReadLine();
            while ("q" != cmd)
            {
                switch (cmd)
                {
                    case "pre":
                        p.plugIn.PreRun("PreRun");
                        break;
                    case "run":
                        p.plugIn.PreRun("Run");
                        break;
                    case "post":
                        p.plugIn.PreRun("PostRun");
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
