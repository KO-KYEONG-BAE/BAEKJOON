using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int tCase = int.Parse(Console.ReadLine());
            int[] CaseInput = new int[tCase];
            for (int i = 0; i < tCase; i++){
                CaseInput[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tCase; i++){
                Console.WriteLine("{0} {1} {2} {3}", CaseInput[i] / 25, CaseInput[i] % 25 / 10, CaseInput[i] % 25 % 10 / 5, CaseInput[i] % 25 % 10 % 5 / 1);
            }
        }
    }
}
