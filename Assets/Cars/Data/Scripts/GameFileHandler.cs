using System.IO;
using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cars.Data
{
    public class GameFileHandler : MonoBehaviour
    {
        public static GameFileHandler Instance;

        private string _path;
        private PlayerDataHandler _playerData;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;

            _path = Path.Combine(Application.persistentDataPath, "saved.json");
            _playerData = GetComponent<PlayerDataHandler>();
            CheckFileExists();
            _playerData.Load();
        }

        private void CheckFileExists()
        {
            if (File.Exists(_path) == false)
            {
                File.Create(_path).Close();
                SetDefaultData();
            }
        }

        private void SetDefaultData()
        {
            int[] score = { 0, 0, 0, 0, 0 };
            List<int> cars = new List<int> { 0 };
            int lollipop = 5;

            _playerData.SetNewPlayerData(score, cars, lollipop);
            Save();
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(_playerData.Player);
            File.WriteAllText(_path, json);
        }

        public T Load<T>()
        {
            string json = File.ReadAllText(_path);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public void DeleteSave()
        {
            if (File.Exists(_path))
            {
                File.Delete(_path);
                SetDefaultData();
            }
        }
    }
}

