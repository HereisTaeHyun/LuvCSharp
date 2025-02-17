class MyIndexer
{
    private const int MAX = 10;
    private string name;
    private int[] data = new int[MAX];

    public int this[int index]
    {
        get
        {
            if(index < 0 || index >= MAX)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return data[index]; 
            }
        }
        set
        {
            if(!(index < 0 || index >= MAX))
            {
                data[index] = value; 
            }
        }
    }
}