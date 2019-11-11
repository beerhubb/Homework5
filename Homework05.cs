using System;

namespace NO1
{


    public class led : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
            Console.WriteLine("On/Off :" + ledNo);
            int x = 0;
            string[] d = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "" };
            int[] num = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string e = (" 1  2  3  4  5  6  7  8  9  10");
            var ww = "[!]";
            var dd = "[ ]";
            while (x < 10)
            {
                int input = int.Parse(Console.ReadLine());
                int b = 1;
                b = input - b;
                var bb = 1 == num[b];
                if (bb)
                {
                    d[b] = dd;
                    Console.WriteLine(d[0] + d[1] + d[2] + d[3] + d[4] + d[5] + d[6] + d[7] + d[8] + d[9] + d[10]);
                    Console.WriteLine(e);
                    num[b] = 0;
                }
                else
                {
                    d[b] = ww;
                    Console.WriteLine(d[0] + d[1] + d[2] + d[3] + d[4] + d[5] + d[6] + d[7] + d[8] + d[9] + d[10]);
                    Console.WriteLine(e);
                    num[b] = 1;
                }
            }
            return ledNo;
        }
    }
}