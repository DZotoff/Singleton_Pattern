using singleton_task;

internal class Program
{
    private static void Main(string[] args)
    {
        Logger.Instance.LogMess("Hello, this is a new log message for You.");// logger access to print messages
        Console.ReadKey();
    }
}