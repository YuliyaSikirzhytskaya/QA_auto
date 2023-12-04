using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace MailAutomationTest
{
    internal class JsonLogger: ILogger
    {
        string _fileName;

        public JsonLogger(string fileName)
        {
            _fileName = fileName;
        }

        public object CreateJsonObject(string record) 
        {
            return new { Log = record };
        }
        public void SaveJson(object jsonRecord) 
        {
            using (StreamWriter file = File.AppendText(@"D:\QA_auto\MailAutomationTest\JsonFileLog.json")) 
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, jsonRecord);
            }
        }
        public void LogError(string error)
        {
            var jsonObject = CreateJsonObject(error);
            SaveJson(jsonObject);
            
        }

        public void LogMessage(string message)
        {
            var jsonObject = CreateJsonObject(message);
            SaveJson(jsonObject);
        }

        public void LogWarning(string warning)
        {
            var jsonObject = CreateJsonObject(warning);
            SaveJson(jsonObject);
        }
    }
}
