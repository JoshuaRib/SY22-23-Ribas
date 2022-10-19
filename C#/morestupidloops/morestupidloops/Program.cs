using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace morestupidloops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            WriteLine("enter a number you wanna see get multipied,no decimals.");
            num = int.Parse(ReadLine());
            WriteLine(num);
            ReadKey();
            for (int i = 1; i < 10; i++)
            {
                for (int h = 1; h < num; h++)
                {
                Write(i + "x" + h + "=" + i*h + ",");
                }
            }
            ReadKey();
        }
    }
}
