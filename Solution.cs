using System.Formats.Asn1;
using System.Text;
using System.Linq;

class Solution 

{
    public int solution0207(int[] num_list) {
        int odd = 0;
        int even = 0;
        for(int i = 0; i < num_list.Length; i++)
        {
            if(i % 2 == 0)
            {
                even += num_list[i];
            }
            else if(i % 2 == 1)
            {
                odd += num_list[i];
            }
        }
        return even > odd ? even:odd;
    }

    public int[] solution0206(int start_num, int end_num) {
        int[] answer = new int[end_num - start_num + 1];
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = start_num;
            start_num += 1;
        }
        return answer;
    }
    public int solution0205(int a, int b) {
        int answer = 0;
        int merge = Int32.Parse(a.ToString() + b.ToString());
        int compare = 2 * a * b;
        
        answer = merge >= compare ? merge : compare;
        
        return answer;
    }
    public string solution02042(int[] numLog)
    {
        string answer = "";
        StringBuilder stringBuilder = new StringBuilder();
        for(int i = 1; i < numLog.Length; i++)
        {
            int diff =  numLog[i-1] - numLog[i];
            if(diff == -1)
            {
                stringBuilder.Append('w');
            }
            else if(diff == 1)
            {
                stringBuilder.Append('s');
            }
            else if(diff == -10)
            {
                stringBuilder.Append('d');
            }
            else if(diff == 10)
            {
                stringBuilder.Append('a');
            }
        }
        answer = stringBuilder.ToString();
        return answer;
    }
    public int solution0204(int n, string control)
    {
        foreach(char elem in control)
        {
            if(elem.Equals('w'))
            {
                n += 1;
            }
            else if(elem.Equals('s'))
            {
                n -= 1;
            }
            else if(elem.Equals('d'))
            {
                n += 10;
            }
            else if(elem.Equals('a'))
            {
                n -= 10;
            }
        }
        return n;

        // foreach(char elem in control)
        // {
        //     switch(elem)
        //     {
        //         case 'w':
        //             n += 1;
        //             break;
        //         case 's':
        //             n -= 1;
        //             break;
        //         case 'd':
        //             n += 10;
        //             break;
        //         case 'a':
        //             n -= 10;
        //             break;
        //     }
        //     return n;
        // }
    }
    public int solution0203(int[] num_list) {
        int answer = 0;
        foreach(int elem in num_list)
        {
            if (elem < 0)
            {
                return answer;
            }
            answer += 1;
        }
        return -1;
    }
    public int solution01312(int n)
    {
        int answer;
        if(n % 7 != 0)
        {
            answer = n / 7 + 1;
        }
        else
        {
            answer = n / 7;
        }
        return answer;
    }
    public int[] solution0131(int[] numArray)
    {

        // int[] answer = new int[numArray.Length];
        // for(int i = 0; i < numArray.Length; i++)
        // {
        //     answer[i] = numArray[numArray.Length - 1 - i];
        // }
        // return answer;

        Array.Reverse(numArray);
        return numArray;
    }
    public string solution01272(string my_string) {
        string answer = "";
        foreach(char elem in my_string)
        {
            if(elem != 'a' && elem != 'e' && elem != 'i' && elem != 'o' && elem != 'u' )
            {
                answer += elem;
            }
        }
        return answer;
    }
    public int[] solution0127(string[] strlist) {
        int[] answer = new int[strlist.Length];
        int pointer = 0;
        foreach (string word in strlist)
        {
            answer[pointer] = word.Length;
            pointer++;
        }
        return answer;
    }
    
    public string solution01242(string my_string, int s, int e) {
        string answer = "";
        char[] chars = my_string.ToArray();
        Array.Reverse(chars, s, e - s + 1);
        answer = new string(chars);
        return answer;
    }
    public string solution0124(string my_string) {
        StringBuilder sb = new StringBuilder();
        foreach(char elem in my_string)
        {
            sb.Insert(0, elem);
        }
        return sb.ToString();

        // string answer = "";
        // foreach(char elem in my_string)
        // {
        //     answer = elem + answer;
        // }
        // return answer;

        // string answer = "";
        // for(int i = my_string.Length - 1; i >= 0; i--)
        // {
        //     answer += my_string[i];
        // }
        // return answer;
    }
    public int[] solution0123(int money)
    {
        // int[] answer = new int[2];
        // const int n = 5500;
        // answer[0] = money / n;
        // answer[1] = money % n;

        // return answer;

        const int COFFEE_PRICE = 5500;
        return new int[]{money/COFFEE_PRICE, money%COFFEE_PRICE};
    }
    public int solution0122(string[] s1, string[] s2) {
        int answer = 0;
        foreach(string elem1 in s1)
        {
            foreach(string elem2 in s2)
            {
                if(elem1 == elem2)
                {
                    answer += 1;
                    break;
                }
            }
        }
        return answer;
    }
    public int[] solution0121(int[] numbers) {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i] * 2; 
        }
        return numbers;
    }
    public int solution0120(int slice, int n) {
        int answer = n / slice;
        if(n % slice != 0)
        {
            answer += 1;
        }
        return answer;
    }
    public int[] solution01172(int[] num_list)
    {
        int[] answer = new int[2] {0, 0};
        foreach(int elem in num_list)
        {
            if(elem % 2 == 0)
            {
                answer[0] += 1;
            }
            else
            {
                answer[1] += 1;
            }
        }
        return answer;
    }
    public int solution0117(int[] array, int height)
    {
        int counter = 0;
        foreach(int elem in array) {
            if(elem > height)
            {
                counter += 1;
            }
        }
        return counter;
    }
    public int[] solution01162(int[] numbers, int num1, int num2)
    {
        List<int> store = new List<int>();
        for(int i = num1; i <= num2; i++)
        {
            store.Add(numbers[i]);
        }
        return store.ToArray();
    }
    public int solution0116(string message)
    {
        return message.Length * 2;
    }
    public double solution0115(int[] numbers)
    {
        double answer = 0;
        double store = 0;

        //Linq 버전
        // return numbers.Average();

        // for 버전
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     store += numbers[i];
        // }
        // answer = store / numbers.Length;

        // foreach 버전
        foreach(int elem in numbers)
        {
            store += elem;
        }
        answer = store / numbers.Length;

        return answer ;
    }
    public int solution01142(int n, int k)
    {
        int answer = 0;
        int ser = n / 10;
        answer = (12000 * n) + (2000 * (k - ser));
        return answer;
    }
    public int solution0114(int n)
    {
        int answer = 0;
        for(int i = 0; i <= n; i++)
        {
            if (i % 2 == 0) 
            {
                answer += i;   
            }
        }
        return answer;
    }
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
