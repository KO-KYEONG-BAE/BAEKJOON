using System;

class Baekjoon2292
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int cnt = 0;
        int sum = 1;

        while (input > sum)
        {
            cnt++;
            sum += cnt * 6;
        }

        Console.WriteLine(cnt + 1);
    }
}