public class Model
{
    private int _counter = 0;

    public int GetCounter()
    {
        return _counter;
    }

    public void Increment()
    {
        _counter++;
    }

    public void Reset()
    {
        _counter = 0;
    }
}
