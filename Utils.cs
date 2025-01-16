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
}