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
            Console.WriteLine("Rules: \n" + "- Enter start and end point to count from.\n" + "- If a number divisible by 3 is counted, say \"FIZZ\".\n" +
                "- If a number divisible by 5 is counted, say \"BUZZ\".\n" + 
                "- For numbers divisible by both 3 and 5, say \"Fizz-Buzz!\".\n");

            var start = 0;
            var end = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Start point: ");
                    start = int.Parse(Console.ReadLine());
                    Console.WriteLine("End point: ");
                    end = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    break;
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message + "\n" + "Please Enter numeric values only.\n");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message + "\n" + "Please Enter numeric values only.\n");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + "\n" + "Please Enter numeric values only.\n");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message + "\n" + "Please Enter numeric values only.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n" + "Please Enter numeric values only.\n");
                }
            }


            for (i = start; i < end; i++)
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
                else if (i%3 ==0 && i%5 ==0)
                {
                    Console.WriteLine("FIZBUZZ!" + " (" + i + ")");
                }
            }
            Console.ReadLine();
        }
    }
}
