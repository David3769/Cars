using UnityEngine;

namespace Cars.UI
{
    public class ChangeCar : MonoBehaviour
    {
        [SerializeField] private ScriptableObject[] _scriptableObjects;
        [SerializeField] private DisplaySelectionCar _displaySelectionCar;

        private int _currentIndex;

        public void Change(int change)
        {
            _currentIndex += change;

            _currentIndex = _currentIndex < 0 ? _scriptableObjects.Length - 1 : _currentIndex;
            _currentIndex = _currentIndex > _scriptableObjects.Length - 1 ? 0 : _currentIndex;

            _displaySelectionCar.Display((Car)_scriptableObjects[_currentIndex]);
        }

        public Car GetCurrentCar()
        {
            return (Car)_scriptableObjects[_currentIndex];
        }
    }
}