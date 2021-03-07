using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace args
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in args)
            {
                Console.WriteLine(args);
            }
            Console.Read();
        }
    }
}
