using System;

namespace NO1
{
    public class led : IHomework05
    {
        public string[] value = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        public int[] inputnum = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public string DisplayLEDOnScreen(string ledNo)
        {
            string result = null;
            var YES = "[!]";
            var NO = "[ ]";
            if (ledNo == "A")
            {
                if (value[9] == NO)
                {
                    value[9] = YES;
                    foreach (var item in value)
                    {
                        result += item;
                    }
                }
                else
                {
                    value[9] = NO;
                    foreach (var item in value)
                    {
                        result += item;
                    }
                }
            }
            else
            {
                var goo = int.Parse(ledNo);
                goo = goo - 1;
                if (inputnum[goo] == 1)
                {
                    value[goo] = NO;
                    foreach (var item in value)
                    {
                        result += item;
                    }
                    inputnum[goo] = 0;
                }
                else
                {
                    value[goo] = YES;
                    foreach (var item in value)
                    {
                        result += item;
                    }
                    inputnum[goo] = 1;
                }
            }
            return result;
        }
    }
}
