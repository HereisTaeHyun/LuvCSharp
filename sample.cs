using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

class Sample

{
    // Enum, Flags 잘 쓰면 좋음 가독성이 좋아진다
    [Flags]
    enum Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8,
    }
    public void EnumSample()
    {
        Border border;
        border = Border.Top | Border.Bottom | Border.Left;

        if (border.HasFlag(Border.Bottom))
        {
            Console.WriteLine(border.ToString());
        }
    }
    public void StringBuilder()
    {
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < 26; i++)
        {
            sb.Append((char)('A' + i));
            sb.Append(System.Environment.NewLine);
        }
        string s = sb.ToString();
        Console.WriteLine(s);
    }
    public void StringSample()
    {
        string s1 = "C#";
        string s2 = "Programming";
        char cha1 = 'a';
        char cha2 = 'b';

        string s3 = s1 + s2;
        Console.WriteLine($"String0 : {s3}");

        string subString = s3.Substring(1, 5);
        Console.WriteLine($"subString : {subString}");

        string s = "C# studies";
        for(int i = 0; i < s.Length; i++)
        {
            Console.WriteLine($"{i} : {s[i]}");
            Console.WriteLine("{0} : {1}", i, s[i]);
            Console.WriteLine("-----------------");
        }

        string str = "Hello";
        char[] charArray = str.ToArray();

        for(int i = 0; i < charArray.Length; i++)
        {
            Console.WriteLine(charArray[i]);
        }
        s = new string(charArray);
        Console.WriteLine(s);

        char c1 = 'A';
        char c2 = (char)(c1 + 3);
        Console.WriteLine(c2);
    }
    public void Dictionary()
    {
        List<char> cList = new List<char>();
        var cListVar = new List<char>();
        var dic = new Dictionary<int, int>();

        Hashtable ht = new Hashtable();
        ht.Add("First", "Irina");
        ht.Add("Second", "Tom");
        if (ht.Contains("Second"))
        {
            Console.WriteLine(ht["Second"]);
        }

        Dictionary<int, string> emp = new Dictionary<int, string>();
        emp.Add(1, "Fisrt");
        emp.Add(2, "Second");
        emp.Add(3, "Third");
        emp.Add(4, "Forth");
        emp.Add(5, "Fifth");

        int dicSize = emp.Count();
        string thirdName = emp[3];
        Console.WriteLine($"dicSize : {dicSize}");
        if (emp.ContainsKey(3))
        {
            Console.WriteLine($"thirdName : {thirdName}");
        }

    }
    public void QueueStack()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(120);
        q.Enqueue(50);
        q.Enqueue(40);
        q.Enqueue(300);
        q.Enqueue(20);

        int next = q.Dequeue();
        int qSize = q.Count();

        Console.WriteLine($"Qsize : {qSize}");
        Console.WriteLine($"Next : {next}");
        next = q.Dequeue();
        Console.WriteLine($"Next : {next}");

        Console.WriteLine("--------------------------------------");

        Stack<float> s = new Stack<float>();

        s.Push(120.0f);
        s.Push(50.0f);
        s.Push(40.0f);
        s.Push(300.0f);
        s.Push(20.0f);

        float val = s.Pop();
        float sSize = s.Count();


        Console.WriteLine($"sSize : {sSize}");
        Console.WriteLine($"val : {val}");
    }
    public void DataType()
    {
        bool b = true;
        int i = 50465;
        long l = 46545646L;
        float f = 1.45645f;
        double d = 1.48448d;
        decimal d2 = 123.45m;

        char c = 'a';
        string s = "string";

        DateTime dt = new DateTime(2025, 1, 13, 10, 24, 00);
    }

    public void Array ()
    {
        string[] players = new string[10];
        Console.WriteLine("PlayersNum : " + players.Length);
        int[] intArray = new int[100];
        char[] cc = new char[5];
        int[] abc = new int[3];
        int[] abc2 = new int[3] {1, 2, 3};
        string[] regions = new string[3] {"", "", ""};

        string[,] depts = new string[2, 2];
        int[,] int2 = new int[,]{{1, 2}, {2, 3}, {3, 4}};

        string[,,] cubes = new string[2, 3, 4];

        // 가능하나 비추천하는 방법, 다만 배열이 차원별로 크기가 다를 경우 사용하는 경우도 있음
        int[][] li = new int[2][];

        int[] scores = new int[] {80, 78, 60, 90, 100};
        Console.WriteLine(scores.Sum());
        // int sum = 0;
        // for (int i = 0; i < scores.Length; i++)
        // {
        //     sum += scores[i];
        // }
        // Console.WriteLine(sum);
    }
    public void RandomSum()
    {
        int[] ss = new int[10];
        int[] sums = new int[10];
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            ss[i] = rand.Next() % 100;
            Console.WriteLine($"nums {i} : {ss[i]}");
        }
        Console.WriteLine(ss.Sum());
        Console.WriteLine(string.Join(", ", ss));
    }
    public void List()
    {
        List<int> ilst = new List<int>();
        List<char> clst = new List<char>();
        List<float> flst = new List<float>();
        List<bool> blst = new List<bool>();
        List<string> slst = new List<string>();

        ilst.Add(10);
        ilst.Add(1);
        ilst.Add(100);
        ilst.Add(150);
        ilst.Remove(10);
        int len = ilst.Count();

    }
    public void LinkedList() {
        LinkedList<int> linkIntLst = new LinkedList<int>();
        LinkedList<string> linkStringLst = new LinkedList<string>();
        linkStringLst.AddLast("Banana");
        linkStringLst.AddLast("Apple");
        linkStringLst.AddLast("Durian");
        linkStringLst.AddLast("Mango");

        LinkedListNode<string> node = linkStringLst.Find("Banana");
        LinkedListNode<string> newnode = new LinkedListNode<string>("Orange");

        linkStringLst.AddAfter(node, newnode);

        linkStringLst.ToList<string>().ForEach(p => Console.WriteLine(p));

        Console.WriteLine("-----------------------구분자-----------------------");

        foreach(string elem in linkStringLst)
        {
            Console.WriteLine(elem);
        }
    }
}
