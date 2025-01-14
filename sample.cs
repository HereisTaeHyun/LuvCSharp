class Sample

{
    public void DataType()
    {
        bool b = true;
        int i = 50465;
        long l = 46545646L;
        float f = 1.45645f;
        double d = 1.48448d;
        decimal d2 = 123.45m;

        char c = 'a';
        string s = "string";

        DateTime dt = new DateTime(2025, 1, 13, 10, 24, 00);
    }

    public void Array ()
    {
        string[] players = new string[10];
        Console.WriteLine("PlayersNum : " + players.Length);
        int[] intArray = new int[100];
        char[] cc = new char[5];
        int[] abc = new int[3];
        int[] abc2 = new int[3] {1, 2, 3};
        string[] regions = new string[3] {"", "", ""};

        string[,] depts = new string[2, 2];
        int[,] int2 = new int[,]{{1, 2}, {2, 3}, {3, 4}};

        string[,,] cubes = new string[2, 3, 4];

        // 가능하나 비추천하는 방법, 다만 배열이 차원별로 크기가 다를 경우 사용하는 경우도 있음
        int[][] li = new int[2][];

        int[] scores = new int[] {80, 78, 60, 90, 100};
        Console.WriteLine(scores.Sum());
        // int sum = 0;
        // for (int i = 0; i < scores.Length; i++)
        // {
        //     sum += scores[i];
        // }
        // Console.WriteLine(sum);
    }
    public void RandomSum()
    {
        int[] ss = new int[10];
        int[] sums = new int[10];
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            ss[i] = rand.Next() % 100;
            Console.WriteLine($"nums {i} : {ss[i]}");
        }
        Console.WriteLine(ss.Sum());
        Console.WriteLine(string.Join(", ", ss));
    }
}
