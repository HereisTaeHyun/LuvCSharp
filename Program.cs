#define Test
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {

        Sample sample = new Sample();
        int result = sample.solution0425([1,3,2,5,4], 9);
        Console.WriteLine(result);

    }

    // static void MyButtonClick(object sender, EventArgs e)
    // {
    //     Console.WriteLine("버튼 입력");
    // }

    //     static void MyButtonDown(object sender, EventArgs e)
    // {
    //     Console.WriteLine("버튼 누름");
    // }

    // [Conditional("Test")]
    // public void TestConditional()
    // {
    //     Console.WriteLine("TestConditional");
    // }
}