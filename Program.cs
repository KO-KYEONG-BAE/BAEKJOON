using System;

class Baekjoon2745
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        string number = input[0].ToUpper();  // 대문자로 변환 (A~Z 처리)
        int baseNum = int.Parse(input[1]);  // 진법 변환할 숫자
        int sum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            int value;

            if (number[i] >= '0' && number[i] <= '9') 
            {
                value = number[i] - '0';  // 숫자 (0~9)
            }
            else 
            {
                value = number[i] - 'A' + 10;  // 알파벳 (A~Z → 10~35)
            }

            sum += value * (int)Math.Pow(baseNum, number.Length - 1 - i);
        }

        Console.WriteLine(sum);
    }
}