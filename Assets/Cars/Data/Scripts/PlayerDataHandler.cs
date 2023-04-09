using System.Collections.Generic;
using UnityEngine;

namespace Cars.Data
{
    public class PlayerDataHandler : MonoBehaviour
    {
        public static PlayerDataHandler Instance { get; private set; }

        private const string SELECTION_INDEX_CAR_PATH = "SelectionIndexCar";

        public int CurrentIndexCar = 0;
        public PlayerData Player;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
        }

        public void SetNewPlayerData(int[] scoreDistance, List<int> cars, int lollipop)
        {
            Player = new PlayerData(scoreDistance, cars, lollipop);
        }

        public void Load()
        {
            Player = GameFileHandler.Instance.Load<PlayerData>();
        }

        public bool CheckOnMyCar()
        {
            if (Player.Cars.Contains(CurrentIndexCar))
                return true;
            else
                return false;
        }

        public void AddCar(int index)
        {
            Player.Cars.Add(index);
        }

        public void TakeLollipop(int count)
        {
            if (count > 0 || count < Player.Lollipop)
            {
                Player.Lollipop -= count;
            }
        }

        public void AddLollipop(int count)
        {
            if (count > 0)
                Player.Lollipop += count;
        }

        public void SetSelectionIndexCar()
        {
            PlayerPrefs.SetInt(SELECTION_INDEX_CAR_PATH, CurrentIndexCar);
        }

        public int GetSelectionIndexCar()
        {
            return PlayerPrefs.GetInt(SELECTION_INDEX_CAR_PATH);
        }
    }
}

