class baekjoon2738
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        // 2개의 2D 배열 초기화
        int[][][] IntArray = new int[2][][];
        
        // 첫 번째 배열 입력받기
        IntArray[0] = new int[n][];
        for (int i = 0; i < n; i++)
        {
            IntArray[0][i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }

        // 두 번째 배열 입력받기
        IntArray[1] = new int[n][];
        for (int i = 0; i < n; i++)
        {
            IntArray[1][i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }

        // 배열 합산 후 출력
        for (int i = 0; i < n; i++)
        {
            for (int x = 0; x < m; x++)
            {
                // 두 배열의 값을 더한 후 출력
                Console.Write("{0} ", IntArray[0][i][x] + IntArray[1][i][x]);
            }
            Console.WriteLine();
        }
    }
}
