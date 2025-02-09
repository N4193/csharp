using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type   
    public static string SubstringAfter(this string log,string delimiteur) => log.Split(delimiteur)[1]; 

    public static string SubstringBetween(this string message, string firstDelimeter, string secondDelimeter) => message.Split(firstDelimeter)[1].Split(secondDelimeter)[0];

    public static string Message(this string log) => log.SubstringAfter(": ");
    
    public static string LogLevel(this string log) => log.SubstringBetween("[", "]");
}