using Cars.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Cars.Player
{
    public class PlayerCar : MonoBehaviour
    {
        public List<int> MyCar;

        private void Start()
        {
            PlayerData playerData = new PlayerData();
            MyCar = playerData.MyCar;
            MyCar.Add(0);
        }

        public void AddCar(int index)
        {
            MyCar.Add(index);
        }

        public bool CheckOnMyCar(int index)
        {
            return MyCar.Contains(index);
        }

        public List<int> GetMyCar()
        {
            return MyCar;
        }
    }
}

