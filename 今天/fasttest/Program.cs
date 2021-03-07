using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasttest
{
    class Program
    {
        static void Main(string[] args)
        {
            //// TimeSpan 練習
            //DateTime startTime = DateTime.Now;
            //Console.WriteLine("program star");
            //SleepHelp.SleepAwhile(3);

            //DateTime endTime = DateTime.Now;
            //TimeSpan ts = endTime - startTime;
            //Console.WriteLine(" Program End. total use " + ts.TotalMilliseconds);
            //Console.ReadLine();

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            Console.WriteLine("Program Start");
            sw.Start();
            SleepHelp.SleepAwhile(1);
            sw.Stop();

            //此段可入需要去除計時的時間段程式碼

            sw.Start();
            SleepHelp.SleepAwhile(2);
            sw.Stop();

            Console.WriteLine(" Program End. total use " + sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
