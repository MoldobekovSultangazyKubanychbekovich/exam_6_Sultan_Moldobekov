using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace exam_6
{
    internal class Serializer
    {
        private static List<Task> Tasks = new List<Task>();
        public static string path = "../../../tasks.json";
        public static List<Task> GetTasks()
        {
            try
            {
                if (Tasks.Count == 0)
                {
                    string json = File.ReadAllText(path);
                    if (json.Length == 0)
                        json = "[]";
                    Tasks = JsonSerializer.Deserialize<List<Task>>(json);
                }
                return Tasks;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }
        }
        public static void OverrideFile(List<Task> emp)
        {
            try
            {
                File.WriteAllText(path, JsonSerializer.Serialize(emp));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
