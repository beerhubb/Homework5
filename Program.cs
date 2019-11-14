using System;

namespace NO1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ledd = new led();
            try
            {
                var a = 1;
                while (a < 2)
                {
                    var input = Console.ReadLine();
                    var test = ledd.DisplayLEDOnScreen(input);
                    Console.WriteLine(test);
                    for (int i = 1; i <=10; i++)
                    {
                        Console.Write($" {i} ");
                    }
                    Console.WriteLine();
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error..");
            }
        }
    }
}
