using System;

namespace baekjoon
{
    

    class System
    {
        static void Main(string [] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            int result1 = int.Parse(a) + int.Parse(b) - int.Parse(c);
            int result2 = int.Parse(a + b) - int.Parse(c);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}