using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Logger
{
    public class Log
    {
        public Log()
        {}
        public Log(string logLevel, string message, string source)
        {
            string logFilePath = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}.json";
            LogEntry logEntry = new LogEntry
            {
                Timestamp = DateTime.Now,
                LogLevel = logLevel,
                Message = message,
                Source = source
            };

            List<LogEntry> logEntries = new List<LogEntry>();

            // Read existing log entries
            if (File.Exists(logFilePath))
            {
                string existingLogs = File.ReadAllText(logFilePath);
                if (!string.IsNullOrEmpty(existingLogs))
                {
                    logEntries = JsonConvert.DeserializeObject<List<LogEntry>>(existingLogs);
                }
            }

            // Add the new log entry
            logEntries.Add(logEntry);

            // Write the updated log entries to the file
            string json = JsonConvert.SerializeObject(logEntries, Formatting.Indented);
            File.WriteAllText(logFilePath, json);
        }
    }
}
