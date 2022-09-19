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
            test(true, "r",true);
            
        }

        static void test(bool ok, string lol, bool ok1)
        {
            if(ok && ok1)
            {
                Console.WriteLine("ok");
                Console.WriteLine(lol);
            }
        }
    }
}
