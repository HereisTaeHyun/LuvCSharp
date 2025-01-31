static class Utils
{
    // 도구 모음집
    public static void PringIntArray(int[] intArray)
    {
        Console.Write("[");
        for(int i = 0; i < intArray.Length; i++)
        {
            if (i != 0)
            {
                Console.Write(", ");
            }
            Console.Write(intArray[i]);
            
        }
        Console.Write("]");
    }

    public static void MakeLotto()
    {
        // 상수 둘
        const int MAX_NUMBER = 45;
        const int PICK_COUNT = 6;

        // 볼 담을 리스트
        var list = new List<int>();

        Random random = new Random();
        int count = 0;
        while(count < PICK_COUNT)
        {
            int pick = random.Next(1, MAX_NUMBER + 1);
            if(!list.Contains(pick))
            {
                list.Add(pick);
                count += 1;
            }
        }

        list.Sort();
        Console.Write("이번 주 로또 번호는");
        Console.Write($" ");
        foreach(int elem in list)
        {
            Console.Write($"{elem}");
            Console.Write($" ");
        }
        Console.WriteLine("입니다");
    }

}