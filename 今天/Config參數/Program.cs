using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Config參數
{
    class Program
    {
        static void Main(string[] args)
        {
            //取得config,課本第4章 延伸 - 索引子
            string sourcePath = ConfigurationManager.AppSettings["SourceFilePath"];
            string targetPath = ConfigurationManager.AppSettings["TargetFilePath"];

            Console.WriteLine(" " + sourcePath);
            Console.WriteLine(" " + targetPath);

            Console.Read();
        }
    }
}
