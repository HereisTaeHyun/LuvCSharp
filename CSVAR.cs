class CSVAR
{
    // field(팔드) 전역 변수
    int glovalVar;
    const int MAX = 2048;
    readonly int Max;
    public void method1()
    {
        int localVar = 100;
        int max = 500;

        if (max < MAX)
        {
            Console.WriteLine(glovalVar);
            Console.WriteLine(localVar);
        }
    }
}