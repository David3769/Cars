using Cars.UI;
using System.Collections.Generic;
using UnityEngine;

namespace Cars.Player
{
    public class PlayerInformation : MonoBehaviour
    {
        public int Lollipop { get; private set; } = 1000000;

        private List<int> _indexMyCar = new List<int>();

        [SerializeField] private Lollipop _lollipop;

        public bool TakeLollipops(int countLollipops)
        {
            if (Lollipop > countLollipops && countLollipops >= 0)
            {
                Lollipop -= countLollipops;
                _lollipop.UpdateLollipop();
                return true;
            }

            return false;
        }

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

