using System;

public enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42    
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        
        switch(logLine.Split("[")[1].Split("]")[0])
        {
            case "TRC":
                return LogLevel.Trace;
                break;
            case "DBG":
                return LogLevel.Debug;
                break;
            case "INF":
                return LogLevel.Info;
                break;
            case "WRN":
                return LogLevel.Warning;
                break;
            case "ERR":
                return LogLevel.Error;
                break;
            case "FTL":
                return LogLevel.Fatal;
                break;             
        }
        //Console.WriteLine(LogLevel.Unknown.)
        return LogLevel.Unknown; 
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        String _OutputForShortLog = $"{(int)logLevel}:{message}";
        return $"{(int)logLevel}:{message}";
    }
}
