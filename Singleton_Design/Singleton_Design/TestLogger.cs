using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns._11Sigleton
{
    class TestLogger
    {
        static void Main()

        {
            //Logger obj1 = new Logger();
            //Logger obj2 = new Logger();
            // Logger obj1 = Logger.GetInstance();
            // Logger obj2 = Logger.GetInstance();
            Logger obj1 = Logger.Instance;
            Logger obj2 = Logger.Instance;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
        }
    }
}
