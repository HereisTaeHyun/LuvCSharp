namespace MySystem;

class MyCalss
{
    private delegate void RunDelegate(int i);

    private void RunThis(int i)
    {
        Console.WriteLine($"Value : {i}");
    }

    private void RunThis2(int i )
    {
        Console.WriteLine($"Value : {i:X}");
    }

    public delegate int CompareDelegate(int i1, int i2);

    public static int Compare(int i1, int i2)
    {
        return i1 > i2 ? i1 : i2;
    }

    public void Perform()
    {
        RunDelegate run = new RunDelegate(RunThis);

        run(100);
        run(150);

        run = RunThis2;
        run(100);
        run(150);

        CompareDelegate compareDelegate = new CompareDelegate(Compare);
        compareDelegate(10, 500);
    }


}