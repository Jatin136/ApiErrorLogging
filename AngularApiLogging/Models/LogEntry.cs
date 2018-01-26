using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularApiLogging.Models
{
    public enum LogLevel
    {
        All = 0,
        Debug = 1,
        Info = 2,
        Warn = 3,
        Error = 4,
        Fatal = 5,
        Off = 6
    }

    public class LogEntry
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public LogLevel Level { get; set; }
        public bool LogWithDate { get; set; }
        public string[] ExtraInfo { get; set; }
    }
}