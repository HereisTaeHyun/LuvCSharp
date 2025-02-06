internal class Program
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

        MyCustomer customer1 = new MyCustomer("Biktor", 27);
        customer1.YearMoney = 500;
        Console.WriteLine($"{customer1.GetCustomerDate()}");
    }
}