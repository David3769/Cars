using UnityEngine;

namespace Cars.UI
{
    public class ChangeCar : MonoBehaviour
    {
        [SerializeField] private ScriptableObject[] _cars;
        [SerializeField] private DisplaySelectionCar _displaySelectionCar;

        public static int CurrentIndex { get; private set; }

        private void Start()
        {
            if (_displaySelectionCar == null)
                _displaySelectionCar = FindObjectOfType<DisplaySelectionCar>()
                    .GetComponent<DisplaySelectionCar>();
        }

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