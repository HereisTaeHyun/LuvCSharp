﻿internal class Program
{
    private static void Main(string[] args)
    {
        // Solution sol = new Solution();
        // int result = sol.solution0204(0, "wsdawsdassw");
        // Console.WriteLine($"결과물 : {result}");

        // Sample sample = new Sample();
        // sample.TryCatch();

        // CSVAR obj = new CSVAR();
        // obj.method1();

        // Utils.MakeLotto();

        // MyCustomer customer1 = new MyCustomer("Biktor", 27);
        // customer1.YearMoney = 500;
        // Console.WriteLine($"{customer1.GetCustomerDate()}");

        // MyButton myButton = new MyButton();
        // myButton.Click += new EventHandler(MyButtonClick); // 이벤트 가입은 +=, -=으로 가입 및 탈퇴
        // myButton.Click += new EventHandler(MyButtonDown);
        // myButton.Click -= new EventHandler(MyButtonDown);
        // myButton.Text = "Run";
        // myButton.MouseButtonDown();

        MyIndexer myIndexer = new MyIndexer();
        myIndexer[0] = 1;
        Console.WriteLine(myIndexer[0]);
        // myIndexer[11] = 11;
        // Console.WriteLine(myIndexer[11]);

    }

    static void MyButtonClick(object sender, EventArgs e)
    {
        Console.WriteLine("버튼 입력");
    }

        static void MyButtonDown(object sender, EventArgs e)
    {
        Console.WriteLine("버튼 누름");
    }
}