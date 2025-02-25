class baekjoon2738
{
    static void Main(string[] args)
    {
        int[][] IntArray = new int [9][];
        for (int i = 0; i < 9; i++)
        {
            IntArray[i] = new int[9];
            string[] input = Console.ReadLine().Split();
            for (int x = 0; x < 9; x++)
            {
                IntArray[i][x] = int.Parse(input[x]);
            }
        }

        int max = 0;
        int n = 0;
        int m = 0;

        for (int i = 0; i < 9; i++)
        {
            for (int x = 0; x < 9 ; x++)
            {
                if (IntArray[i][x] == IntArray[n][m])
                {
                    continue;
                }
                if (max < IntArray[i][x])
                {
                    max = IntArray[i][x];
                    n = i;
                    m = x;
                }
            }
        }

        Console.WriteLine(max);
        Console.WriteLine("{0} {1}", n + 1, m + 1);
    }
}
