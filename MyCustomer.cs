using System;

public class MyCustomer
{
    private string name;
    private int age;
    private long yearmoney;

    public event EventHandler nameChanged;

    public MyCustomer()
    {
        name = string.Empty;
        age = -1;
    }
    public MyCustomer(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (this.name != value)
            {
                this.name = value;
                if(nameChanged != null)
                {
                    nameChanged(this, EventArgs.Empty);
                }
            }
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }

    public long YearMoney
    {
        get
        {
            return this.yearmoney;
        }
        set
        {
            if(value < 0)
            {
                Console.WriteLine("음수 입력 에러");
            }
            else
            {
                this.yearmoney = value;
            }
        }
    }

    public string GetCustomerDate()
    {
        string data = $"Name : {this.name} Age : {this.age}";
        return data;
    }
}