// See https://aka.ms/new-console-template for more information
internal class Stopwatch
{
    private DateTime _startTime;
    private DateTime _stopTime;

    public void Start()
    {
        if (_startTime > _stopTime)
            throw new InvalidOperationException("Stopwatch cannot be started again before it has stopped");
        _startTime = DateTime.Now;
    }

    public void Stop()
    {
        _stopTime = DateTime.Now;
    }

    public TimeSpan GetTime()
    {
        return _stopTime - _startTime;
    }
}
