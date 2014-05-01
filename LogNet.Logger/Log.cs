using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogNet.Logger
{
   public class Log
    {
       public static void Add(LogLevel level,LogType type,  string[] tags, string stackTrace, string text ){

       }
       public static void Add(LogType type, string[] tags, string stackTrace, string text)
       {
           Add(LogLevel.NORMAL, type, tags, stackTrace, text);
       }
       public static void Add(string[] tags, string stackTrace, string text)
       {
           Add(LogLevel.NORMAL, LogType.MESSAGE,  tags, stackTrace, text);
       }
       public static void Add(string stackTrace, string text)
       {
           Add(LogLevel.NORMAL, LogType.MESSAGE, new string[] { LogConfig.DEFAULT_TAG }, stackTrace, text);
       }
       public static void Add(LogType type, string text)
       {
           Add(LogLevel.NORMAL, type, new string[] { LogConfig.DEFAULT_TAG }, "", text);
       }
       public static void Add(LogType type, string stackTrace, string text)
       {
           Add(LogLevel.NORMAL, type, new string[] { LogConfig.DEFAULT_TAG }, stackTrace, text);
       }
       public static void Add(LogLevel level, LogType type, string text)
       {
           Add(level, LogType.MESSAGE, new string[] { LogConfig.DEFAULT_TAG }, "", text);
       }
       public static void Add( string text)
       {
           Add(LogLevel.NORMAL, LogType.MESSAGE, new string[] { LogConfig.DEFAULT_TAG }, "", text);
       }
    }
}