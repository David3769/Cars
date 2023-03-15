using UnityEngine;

namespace Cars.UI
{
    public class ChangeCar : MonoBehaviour
    {
        [SerializeField] private ScriptableObject[] _cars;
        [SerializeField] private DisplaySelectionCar _displaySelectionCar;

        public int CurrentIndex { get; private set; }

        public void Change(int change)
        {
            CurrentIndex += change;

            CurrentIndex = CurrentIndex < 0 ? _cars.Length - 1 : CurrentIndex;
            CurrentIndex = CurrentIndex > _cars.Length - 1 ? 0 : CurrentIndex;

            _displaySelectionCar?.Display(_cars[CurrentIndex] as Car);
        }

        public Car GetCurrentCar()
        {
            return _cars[CurrentIndex] as Car;
        }
    }
}