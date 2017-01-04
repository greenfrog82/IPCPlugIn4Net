using System;

namespace DotNetVO
{
    public class Param
    {
        public string PreRun { get; set; }
        public string Run { get; set; }
        public string PostRun { get; set; }

        public Param(string preRun, string run, string postRun)
        {
            PreRun = preRun;
            Run = run;
            PostRun = postRun;
        }
    }
}
