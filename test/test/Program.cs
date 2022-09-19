using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test(true, "r");
            
        }

        static void test(bool ok, string lol)
        {
            if(ok)
            {
                Console.WriteLine("ok");
                Console.WriteLine(lol);
            }
        }
    }
}
