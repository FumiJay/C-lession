using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console參數
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];

            array[0] = 32;
            array[1] = 3;
            array[2] = 1;
            array[3] = 15;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(" " + array[i]);
            }

            Console.Read();

        }
    }
}
