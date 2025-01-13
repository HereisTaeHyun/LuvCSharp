class Solution 

{
    public int solution0113(int num1, int num2)
    {
        int answer = num1 == num2 ? 1:-1;
        return answer;
    }
    public int solution01102(int age)
    {
        int answer = 0;
        int nowYear = 2022;
        answer = nowYear - age + 1;
        return answer;
    }
    public int solution0110(int num1, int num2)
    {
        return num1 % num2;
    }
    public int solution0109(int num1, int num2)
    {
        return num1 - num2;
    }
    public int solution0108(int num1, int num2)
    {
        return num1 * num2;
    }
}
