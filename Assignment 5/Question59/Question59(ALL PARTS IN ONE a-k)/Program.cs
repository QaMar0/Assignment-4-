using System;

namespace Question59_ALL_PARTS_IN_ONE_a_k_
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will be replacing variable "N" with N1,N2,N3 ... (other alphabets too) soo on to write 9 parts of one question in one.
            //Part A
            int n = 22 / 8;
            Console.WriteLine(n);
            //Part B
            int N = 99 / 8 + 21 / 11 * 7;
            Console.WriteLine(N);
            //Part C
            double a1 = 4, b1 = 3, p1 = 8, q1 = 2;
            double N1 = q1 / a1 - p1 / b1;
            Console.WriteLine(N1);
            //Part D
            int a2 = 6, b2 = 3, p2 = 8, q2 = 2;
            double N2 = p2 / a2 + q2 / b2;
            Console.WriteLine(N2);
            //Part E
            double a3 = 3.3, b3 = 2.7, p3 = 8.7, q3 = 5.4;
            double N3 = p3 / b3 + q3 / a3;
            Console.WriteLine(Math.Round(N3));
            //Part F
            int N4 = 11 + 7 / 4 + 98 % 6 * 3;
            Console.WriteLine(N4);
            //Part G
            int N5 = 11 / 31 % 8 * 5 - 12;
            Console.WriteLine(N5);
            //Part H
            double p6=8;
            int q6 = 5;
            double N6 = (q6 * p6) + 3.0 * p6 * p6 - (q6 % 3) * p6 * p6 * p6;
            Console.WriteLine(N6);
            //Part I
            double p7 = 5;
            int q7 = 9;
            double N7 = (q7 % 2) * p7 + 6.0 * p7 * (q7 % 3) + (q7 % 4) * p7 * p7 * p7;
            Console.WriteLine(N7);
            //Part J
            int N8 = 3, a8 = 6, b8 = 2;
            N8 *= a8 + b8;
            a8--;
            N8 %= a8;
            Console.WriteLine(N8);
            //Part K
            int a9,N9=5;
            ++N9;
            a9 = --N9;
            N9 = N9 - a9;
            Console.WriteLine(N9);
        }
    }
}
