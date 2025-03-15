using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int value = 3;
            int subvalue = 2;

            if (input == 1) {
            }
            else {
                for (int i = 0; i < input - 1; i++) {
                value = value + subvalue;
                subvalue = subvalue * 2;
                }
            }

            Console.WriteLine(value * value);
        }
    }
}
