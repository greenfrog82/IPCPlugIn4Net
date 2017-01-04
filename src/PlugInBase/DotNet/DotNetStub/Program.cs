using DotNetPlugIn;
using DotNetVO;
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
                string[] cmdTokens = cmd.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                cmd = cmdTokens[0];
                Param param = JsonNet.Serialize.JsonSerializeHelper.Deserialize<Param>(cmdTokens[1]);

                switch (cmd)
                {
                    case "pre":
                        p.plugIn.PreRun(param);
                        Console.WriteLine(JsonNet.Serialize.JsonSerializeHelper.Serialize(param));
                        break;
                    case "run":
                        p.plugIn.PreRun(param);
                        Console.WriteLine(JsonNet.Serialize.JsonSerializeHelper.Serialize(param));
                        break;
                    case "post":
                        p.plugIn.PreRun(param);
                        Console.WriteLine(JsonNet.Serialize.JsonSerializeHelper.Serialize(param));
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
