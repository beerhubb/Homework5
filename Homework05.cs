using System;

namespace NO1
{
    public class led : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
            Console.WriteLine("On/Off :" + ledNo);
            string[] d = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "" };
            int[] num = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string number = (" 1  2  3  4  5  6  7  8  9  10");
            var ww = "[!]";
            var dd = "[ ]";
            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());
                    input = input - 1;
                    var hubb = (1 == num[input]);
                    if (hubb)
                    {
                        d[input] = dd;
                        foreach (var item in d)
                        {
                            Console.Write(item);
                        }
                        Console.WriteLine();
                        Console.WriteLine(number);
                        num[input] = 0;
                    }
                    else
                    {
                        d[input] = ww;
                        foreach (var item in d)
                        {
                            Console.Write(item);
                        }
                        Console.WriteLine();
                        Console.WriteLine(number);
                        num[input] = 1;
                    }
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error Not Font..");
            }
            return ledNo;
        }
    }
}