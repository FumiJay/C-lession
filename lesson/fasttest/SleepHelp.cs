using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasttest
{
    class SleepHelp
    {
        /// <summary> 暫停程式數秒鐘 </summary>
        /// <param name="second"></param>
        public static void SleepAwhile(int second) 
        {
            Random RanTime = new Random();
            int i = RanTime.Next(10, 500); //回傳括號內的亂數

            int ms = second * i;

            System.Threading.Thread.Sleep(ms);
        }
    }
}
