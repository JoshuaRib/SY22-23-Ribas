using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lower = 0;
            //int upper = 0;
            //WriteLine("enter a low number");
            //lower = int.Parse(ReadLine());
            //WriteLine(lower);
            //ReadKey();
            //WriteLine("enter a high number");
            //upper = int.Parse(ReadLine());
            //WriteLine(upper);
            //count using ++
            //for (int i = 100; i <= 1; i++)
            //{
            //    WriteLine();
            //}
            //ReadKey();
            //// count using --
            //for (int i = 50; i >= 1; i--)
            //{
            //    WriteLine(i);
            //}
            //ReadKey();
            ////count by 2s
            //for (int i = 100; i <= 200; i+=5)
            //{
            //    WriteLine(i);
            //}
            //ReadKey();
            //for (int i = 20; i >= -20; i--)
            //{
            //    if (i == 12)
            //    {
            //        break;
            //    }
            //    WriteLine(i);
            //}
            //for (int v = 1; v < 7; v++)
            //{
            //    for (int h = 1; h <= 6 - v; h++)
            //    {
            //        Write("-");
            //    }
            //    WriteLine();
            //}
            //ReadKey();
            for (int v = 1; v < 5; v++)
            {
                for (int h = 1; h <= 10; h++)
                {
                    Write("*");
                }
                WriteLine();
            }
            ReadKey();
            for (int v = 1; v < 6; v++)
            {
                for (int h = 1; h <= v ; h++)
                {
                    Write("*");
                }
                WriteLine();
            }
            ReadKey();
            for (int v = 0; v < 5; v++)
            {
                for (int h =0; h < 5-v; h++)
                {
                    Write(" ");
                }
                for (int h = 0; h < v + 1; h++)
                {
                    Write("*");
                }
                WriteLine();
            }
            ReadKey();
            for (int v = 0; v < 5; v++)
            {
                for (int h = 0; h < 5 - v; h++)
                {
                    Write(" ");
                }
                for (int h = 0; h < v + 1; h++)
                {
                    Write("*");
                }
                for (int h = 1; h <= v; h++)
                {
                    Write("*");
                }
                WriteLine();
            }
            ReadKey();
            for (int v = 0; v < 5; v++)
            {
                for (int h = 0; h < 5 - v; h++)
                {
                    Write(" ");
                }
                for (int h = 0; h < v + 1; h++)
                {
                    Write(v+1);
                }
                for (int h = 0; h < v; h++)
                {
                    Write(v+1);
                }
                WriteLine();
            }
            ReadKey();
            for (int v = 0; v < 6; v++)
            {
                for (int h = 1; h < 6 - v; h++)
                {
                    Write(" ");
                }
                for (int h = 1; h <= v; h++)
                {
                    Write(1+v-h);
                }
                for (int h = 2; h <= v; h++)
                {
                    Write(h);
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}
