using System;
using System.IO;
using System.Text.Json;
namespace assignment_5
{
    public class LogUtility
    {
        public void writeLog(string name, bool error,int systemId, int instanceId, char action){
            string level = error ? "ERROR" : "INFO";
            DateTime timestamp = DateTime.Now;
            using (StreamWriter sw = File.AppendText(name))
            {
                sw.WriteLine($"{level}: You attempted {action}. SYSTEM: {systemId}. INSTANCE: {instanceId} TIME: {timestamp}");
            }
        }
    }
}