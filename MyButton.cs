class MyButton
{
    public string Text;
    public event EventHandler Click;

    public void MouseButtonDown()
    {
        if(this.Click != null)
        {
            Click(this, EventArgs.Empty);
        }
    }
}