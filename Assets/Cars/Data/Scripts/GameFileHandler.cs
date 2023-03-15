using System.IO;
using UnityEngine;
using Newtonsoft.Json;

namespace Cars.Data
{
    public class GameFileHandler
    {
        private static string _path;

        public static void Save(object item, string nameFile = "data.json")
        {
            _path = Path.Combine(Application.persistentDataPath, nameFile);

            string json = JsonConvert.SerializeObject(item, Formatting.None);
            File.WriteAllText(_path, json);
        }

        public static T Load<T>(string nameFile = "data.json")
        {
            _path = Path.Combine(Application.persistentDataPath, nameFile);

            if (File.Exists(_path))
            {
                string json = File.ReadAllText(_path);
                return JsonConvert.DeserializeObject<T>(json);
            }
            else
                return default(T);
        }
    }
}

