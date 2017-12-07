using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIZZ_BUZZ_TEST
{
    /// <summary>
    ///     C# Console Application
    /// 
    ///     Author: Josh Batchelor, 12/7/2017
    /// 
    ///     Purpose: To make the "Fizz-buzz" work in C#, then go
    ///              on to Python 2.7 / 3.6.
    /// 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("FIZZ-BUZZ TEST:\n");
            Console.WriteLine("Rules: \n" + "- Count from 1 to 20.\n" + "- If a number divisible by 3 is counted, say \"FIZZ\".\n" +
                "- If a number divisible by 5 is counted, say \"BUZZ\".\n" + 
                "- For numbers divisible by both 3 and 5, say \"Fizz-Buzz!\".\n");

            Console.WriteLine("Press Enter to Begin . . .\n");
            Console.ReadLine();

            for (i = 1; i < 21; i++)
            {
                if (i % 3 != 0 || i % 5 != 0 && i < 21)
                {
                    if (i%3 !=0 && i % 5 != 0)
                    {
                        Console.WriteLine(i);
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz!" + " (" + i + ")");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz!" + " (" + i + ")");
                    }
                }
                else
                {
                    Console.WriteLine("FIZBUZZ!" + " (" + i + ")");
                }
            }
            Console.ReadLine();
        }
    }
}
