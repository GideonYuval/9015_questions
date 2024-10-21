using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9015_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        //1
        //implement a recursive function that returns true if all digits of integer n are even, false otherwise
        //follow:
        //AllEven(246)
        //AllEven(138)
        static bool AllEven(int n)
        {
            return false;
        }

        //2
        //implement a recursive function that returns true if digit d is in integer n, false otherwise
        //follow:
        //IsDigitInNumber(12345,3)
        //IsDigitInNumber(12345,7)
        static bool IsDigitInNumber(int n, int d)
        {
            return false;
        }

        //3
        //follow for:
        //WhatDoes1(2349)
        //what does WhatDoes1 do?
        static int WhatDoes1(int n)
        {
            if (n == 0)
                return 0;
            else
                if ((n % 10) % 3 == 0)
                return WhatDoes1(n / 10);
            else
                return (n % 10) + WhatDoes1(n / 10);
        }

        //4
        //follow for:
        //WhatDoes2(12, 15)
        //WhatDoes2(20, 22)
        //WhatDoes2(8, 8)
        //what does WhatDoes2 do?
        static int WhatDoes2(int a, int b)
        {
            if (a > b)
                return 0;
            int sum = 0;
            int current = a;
            while (current != 0)
            {
                if (current % 2 == 0)
                    sum += current % 10;
                current /= 10;
            }
            return sum + WhatDoes2(a + 1, b);
        }


    }
}
