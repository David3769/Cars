using System;
using System.Collections.Generic;

namespace Cars.Data
{
    [Serializable]
    public class PlayerData
    {
        public int[] Score;
        public List<int> Cars;
        public int Lollipop;

        public PlayerData(int[] score, List<int> cars, int lollipop)
        {
            Score = score;
            Cars = cars;
            Lollipop = lollipop;
        }
    }
}
