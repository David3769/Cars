using Cars.UI;
using System.Collections.Generic;
using UnityEngine;

namespace Cars.Player
{
    public class PlayerCar : MonoBehaviour
    {
        private List<int> _indexMyCar = new List<int>();

        public void AddCar(int index)
        {
            _indexMyCar.Add(index);
        }

        public bool CheckInMyCar(int index)
        {
            return _indexMyCar.Contains(index);
        }
    }
}

