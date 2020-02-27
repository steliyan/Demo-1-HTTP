using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Class1();
            c.DoHttpWork();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
