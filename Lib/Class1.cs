using Elastic.Apm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Class1
    {
        public void DoHttpWork()
        {
            AgentComponents ac;
            Console.WriteLine("Begin work...");
            var client = new HttpClient();
            Console.WriteLine("Work done!");
        }
    }
}
