using WarcraftCore;

namespace WarcraftConsole;

public class ConsoleLogger : ILogger
{
    public void Log(string msg)
    {
        Console.WriteLine(msg);
    }
}