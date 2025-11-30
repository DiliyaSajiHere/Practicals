static class LogLine
{
    public static string Message(string logLine)
    {
        int position = logLine.IndexOf(":");
        string message = logLine.Substring(position + 1 ).Trim();
        return message;
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int position1 = logLine.IndexOf("[")+1;
        int position2 = logLine.IndexOf("]");
        string level = logLine.Substring(position1, position2-position1).ToLower();
        return level;
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);
        return $"{message} ({level})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
