using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int correct = 0;
            correct+=showquestion("How dumb is Mr.Clarke", "\n a)no","\n b)very", "\n c)genius", "\n d)pretty dumb","b");
            Console.ReadLine();
            correct+=showquestion("Is this class awesome", "\n a)no", "\n b)yes", "\n c)not even close", "\n d)possibly", "b");
            Console.ReadLine();
            correct += showquestion("Are you lying?", "\n a)maybe", "\n b)yes", "\n c)no", "\n d)all of the above", "b");
            Console.ReadLine();
            correct += showquestion("What is 1+1", "\n a)1", "\n b)2", "\n c)3", "\n d)4", "b");
            Console.ReadLine();
        } 
        public static int showquestion(string question, 
                                        string answer1, 
                                        string answer2, 
                                        string answer3, 
                                        string answer4,
                                        string correct)
        {
            Console.WriteLine(question);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            string answer = Console.ReadLine();
            if (answer.Equals(correct))
            {
                Console.WriteLine("you got it correct");  
                return 1;
            }
                return 0;   

        }
    }
}
