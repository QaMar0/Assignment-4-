using System;

namespace PartB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part b = ");
            int x = 10, y = 15;
            x = x++;
            y = ++y;
            Console.Write(x + ",");
            Console.WriteLine(y);
        }
    }
}
