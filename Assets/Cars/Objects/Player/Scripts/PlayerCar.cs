using System.Collections.Generic;
using UnityEngine;

namespace Cars.Player
{
    public class PlayerCar : MonoBehaviour
    {
        private List<int> _indexCar = new List<int> { 0 };

        public void AddCar(int index)
        {
            _indexCar.Add(index);
        }

        public bool CheckOnMyCar(int index)
        {
            return _indexCar.Contains(index);
        }
    }
}

