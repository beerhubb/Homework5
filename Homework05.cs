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
            string e = (" 1  2  3  4  5  6  7  8  9  10");
            var ww = "[!]";
            var dd = "[ ]";
            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());
                    input = input - 1;
                    var bb = 1 == num[input];
                    if (bb)
                    {
                        d[input] = dd;
                        Console.WriteLine(d[0] + d[1] + d[2] + d[3] + d[4] + d[5] + d[6] + d[7] + d[8] + d[9] + d[10]);
                        Console.WriteLine(e);
                        num[input] = 0;
                    }
                    else
                    {
                        d[input] = ww;
                        Console.WriteLine(d[0] + d[1] + d[2] + d[3] + d[4] + d[5] + d[6] + d[7] + d[8] + d[9] + d[10]);
                        Console.WriteLine(e);
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