using System;

public static class LogAnalysis 
{  
    public static string SubstringAfter(this string log,string delimiteur) => log.Split(delimiteur)[1];
    public static string SubstringBetween(this string message, string firstDelimeter, string secondDelimeter)=> message.Split(firstDelimeter)[1].Split(secondDelimeter)[0];
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log)
    {
        return log;
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type 
    public static string LogLevel(this string log)
    {
        return log;
    }
}